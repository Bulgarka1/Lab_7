using System;

namespace Lab_7
{   
    class Program
    {
        static void Main(string[] args)
        {
            char[] cline = new char[] { 'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', '7' };
            string sline = "Hello world7";

            for (int i = 0; i < cline.Length; i++)
            {
                if (Char.IsNumber(cline[i]))
                {
                    cline[i] = '!';
                }
            }

            for (int i = 0; i < cline.Length; i++)
            {
                Console.Write(cline[i]);
            }
            Console.WriteLine();

            sline = sline.Replace('0', '!').Replace('1', '!').Replace('2', '!').Replace('3', '!').Replace('4', '!').Replace('5', '!').Replace('6', '!').Replace('7', '!').Replace('8', '!').Replace('9', '!');
            Console.WriteLine(sline);
            Console.ReadLine();
        }
    }
}
