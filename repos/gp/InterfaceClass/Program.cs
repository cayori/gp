﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    interface ISort
    {
        int GetY();
    }

    class GameObject : ISort
    {
        public int x;
        public int y;

        public int GetY()
        {
            return y;
        }

        public void Print()
        {
            System.Console.WriteLine("----");
            System.Console.WriteLine("X = " + x);
            System.Console.WriteLine("Y = " + y);
            System.Console.WriteLine("----");
        }
    }

    class Program
    {
        public static void SortGameObject(ArrayList lst)
        {
            // 선택정렬 알고리즘을 사용한다.
            // Y 값을 오름차순으로 정렬한다.
            int min;
            int minIndex;
            object temp;

            for(int i=0; i<lst.Count - 1; i++)
            {
                minIndex = i;
                min = ((ISort)lst[i]).GetY();   // 최소값을 저장
                temp = lst[i];

                for(int j=i+1; j<lst.Count; j++)
                {
                    if(min > ((ISort)lst[j]).GetY())
                    {
                        min = ((ISort)lst[j]).GetY();
                        minIndex = j;
                    }
                }
                temp = lst[minIndex];
                lst[minIndex] = lst[i];
                lst[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            ArrayList listobject = new ArrayList();

            GameObject objA = new GameObject();
            objA.x = r.Next(100);
            objA.y = r.Next(100);

            GameObject objB = new GameObject();
            objB.x = r.Next(100);
            objB.y = r.Next(100);

            GameObject objC = new GameObject();
            objC.x = r.Next(100);
            objC.y = r.Next(100);

            GameObject objD = new GameObject();
            objD.x = r.Next(100);
            objD.y = r.Next(100);

            GameObject objE = new GameObject();
            objE.x = r.Next(100);
            objE.y = r.Next(100);

            listobject.Add(objA);
            listobject.Add(objB);
            listobject.Add(objC);
            listobject.Add(objD);
            listobject.Add(objE);

            SortGameObject(listobject);

            for(int i=0; i<listobject.Count; i++)
            {
                GameObject obj = (GameObject)listobject[i];
                obj.Print();
            }
        }
    }
}
