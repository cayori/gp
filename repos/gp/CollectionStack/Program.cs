using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> sData = new Stack<int>();

            sData.Push(3);
            sData.Push(2);
            sData.Push(1);

            // 값 출력
            PrintAll(sData.GetEnumerator());

            sData.Push(9);
            PrintAll(sData.GetEnumerator());

            sData.Push(10);
            PrintAll(sData.GetEnumerator());

            int rtnValue = sData.Pop();
            System.Console.WriteLine("Pop : {0}", rtnValue);
            PrintAll(sData.GetEnumerator());

            rtnValue = sData.Pop();
            System.Console.WriteLine("Pop : {0}", rtnValue);
            PrintAll(sData.GetEnumerator());
        }

        static void PrintAll(IEnumerator<int> p)
        {
            p.Reset();
            System.Console.Write("Stack Data ==> ");
            while (p.MoveNext())
            {
                System.Console.Write("{0} ", p.Current);
            }
            System.Console.WriteLine();
        }
    }
}
