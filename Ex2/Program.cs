using System;
using System.Linq;
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cNum = new char[] { '1', ' ', '2', ' ', '3', ' ', '4' };
            string sNum = "1 2 3 4";
            int counter = 0;

            for (int i = 0; i < cNum.Length; i++)
            {
                if (Char.IsNumber(cNum[i]))
                {
                    int digit = int.Parse(cNum[i].ToString());
                    if (digit % 2 != 0)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

            int sCounter = (from s in sNum where Char.IsNumber(s) && int.Parse(s.ToString()) % 2 != 0 select s).Count();

            Console.WriteLine(sCounter);

            Console.ReadLine();
        }

    }
}

