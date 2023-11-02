using System;

namespace _0.SumFactorialEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumResult = 0.0;

            List<int> inputList = (Console.ReadLine() ?? "1").Split("").Select(int.Parse).ToList();

            for (int i = 1; i <= inputList.Count; i++)
            {
                if (inputList[i] % 2 == 0)
                {
                    double currentResult = CalculateFactorial(inputList[i]);
                    sumResult += currentResult;
                }
            }

            Console.WriteLine(sumResult);
        }

        static double CalculateFactorial(double number)
        {
            double result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}