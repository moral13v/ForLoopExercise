using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            double counterP1 = 1;
            double counterP2 = 1;
            double counterP3 = 1;


            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1 = counterP1;
                    counterP1++;
                }

                if (num % 3 == 0)
                {
                    p2 = counterP2;
                    counterP2++;
                }

                if (num % 4 == 0)
                {
                    p3 = counterP3;
                    counterP3++;
                }
            }

            Console.WriteLine($"{(p1 / n * 100):f2}%");
            Console.WriteLine($"{(p2 / n * 100):f2}%");
            Console.WriteLine($"{(p3 / n * 100):f2}%");

        }
    }
}
