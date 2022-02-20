using System;


namespace TS_AN_LAB8_task1_
{
    internal class Program
    {
        delegate int MiddleSum(int a, int b, int c);

        internal class Pro
        {
            static void Main(string[] args)
            {
                MiddleSum middleSum = delegate (int a, int b, int c)
                {
                    return (a + b + c) / 3;
                };
                int result = middleSum(72, 7, 132);

                Console.WriteLine("Среднее арифметическое чисел = " + result);

            }
        }
    }
}
