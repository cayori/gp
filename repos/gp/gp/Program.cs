using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp
{
    public delegate int Print(string msg);   

    class Program
    {
        public static int SpeakA(string msg)
        {
            System.Console.Write("A가 말하길 ");
            System.Console.WriteLine(msg);
            return 0;
        }
        public static int SpeakB(string msg)
        {
            System.Console.Write("B가 말하길 ");
            System.Console.WriteLine(msg);
            return 0;
        }

        static void Main(string[] args)
        {
            Print A = new Print(SpeakA);
            Print B = new Print(SpeakB);
            A("안녕");
            B("헬로");

        }
    }
}
