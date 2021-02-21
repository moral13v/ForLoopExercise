using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }

                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (n <1)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }

            if (n < 1)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");

            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (n <2)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");

            }
            if (n <2)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");

            }
        }
    }
}
