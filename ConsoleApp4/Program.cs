using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int val ;
            int i, j, k;
            Console.Write("Input number of lines:");
            val = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
