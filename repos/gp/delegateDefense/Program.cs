using System;
using System.Threading;
using System.Collections;

namespace delegateDefense
{
    class DefenseMachine
    {
        public string Name;
        private GameWorld refworld;

        public DefenseMachine(GameWorld world)
        {
            refworld = world;
            // 위임객체를 다중으로 연결합니다.
            refworld.dgobject += new GameWorld.dg_ThereIsSomeone(ThereIsSomeone);
        }

        public void ThereIsSomeone()
        {
            System.Console.WriteLine(Name + " 이 말하길 : 적들이 침투했다!");
        }

        public void Update()
        {
            System.Console.WriteLine("이름 : " + Name);
        }
    }

    class GameWorld
    {
        public ArrayList gameobjects = new ArrayList();

        // 위임 선언
        public delegate void dg_ThereIsSomeone();
        // 위임 객체
        public dg_ThereIsSomeone dgobject;

        public void Update()
        {
            int nCountOfObjects = gameobjects.Count;
            for(int i=0; i<nCountOfObjects; i++)
            {
                ((DefenseMachine)gameobjects[i]).Update();
            }
            // 특정 조건이 되면 지역에 적들이 존재한다고 각 옵저버들에게 알린다.
            Random r = new Random();
            int nReturn = r.Next(100);
            if(nReturn > 80)
            {
                if(dgobject != null)
                {
                    System.Console.WriteLine("Subject 에 연결된 Observer 의 갯수 : " + dgobject.GetInvocationList().Length);
                    dgobject();
                }
            }
        }
    }
    /// <summary>
    /// Program 클래스 설명
    /// </summary>
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            GameWorld world = new GameWorld();
            DefenseMachine machineA = new DefenseMachine(world);
            machineA.Name = "방위 로봇1";
            DefenseMachine machineB = new DefenseMachine(world);
            machineB.Name = "방위 로봇2";
            DefenseMachine machineC = new DefenseMachine(world);
            machineC.Name = "방위 로봇3";

            // 로봇들을 게임세계에 등록
            world.gameobjects.Add(machineA);
            world.gameobjects.Add(machineB);
            world.gameobjects.Add(machineC);

            bool bLoop = true;
            while (bLoop)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("==== GameWorld Start ====");
                world.Update();
            }
        }
    }
}
