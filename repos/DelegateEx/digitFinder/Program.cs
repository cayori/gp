using System;

namespace digitFinder
{
    class IntegerText
    {
        char[] textNumber;

        public IntegerText(int source)
        {
            textNumber = source.ToString().ToCharArray();
        }

        public char this[int index]
        {
            get
            {
                return this.textNumber[textNumber.Length - index - 1];
            }
            set
            {
                this.textNumber[textNumber.Length - index - 1] = value;
            }
        }

        public int ToInt32()
        {
            return Int32.Parse(ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IntegerText aInt = new IntegerText(123456);

            int step = 1;
            for(int i=0; i<aInt.ToString().Length - 1; i++)
            {
                Console.WriteLine(step + "의 자릿수: " + aInt[i]);
                step *= 10;
            }

            aInt[3] = '5';
            Console.WriteLine(aInt.ToInt32());
        }
    }
}
