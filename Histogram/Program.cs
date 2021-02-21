using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number =int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1 = i - p2 - p3 - p4 - p5;
                }

                else if (number >= 200 && number <= 399)
                {
                    p2 = i - p1 - p3 - p4 - p5;
                }

                else if (number >= 400 && number <= 599)
                {
                    p3 = i - p1 - p2 - p4 - p5;
                }

                else if (number >= 600 && number <= 799)
                {
                    p4 = i - p1 - p2 - p3 - p5;
                }

                else if (number >= 800)
                {
                    p5 = i - p1 - p2 - p3 - p4;
                }
            }

            Console.WriteLine($"{(p1 / n * 100):f2}%");
            Console.WriteLine($"{(p2 / n * 100):f2}%");
            Console.WriteLine($"{(p3 / n * 100):f2}%");
            Console.WriteLine($"{(p4 / n * 100):f2}%");
            Console.WriteLine($"{(p5 / n * 100):f2}%");

        }
    }
}
