using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace makingOwnForm
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm Form1 = new MyForm();

            bool bLoop = true;
            while (bLoop)
            {
                Thread.Sleep(30);
                System.Windows.Forms.Application.DoEvents();
            }
        }
    }
}
