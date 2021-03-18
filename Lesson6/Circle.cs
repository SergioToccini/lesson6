using System;

namespace Lesson6
{
    public static class Circle
    {
        private static readonly Random Random = new Random();

        private static int _countInCircle = 0;

        private static double RandomTo1()
        {
            return Random.NextDouble();
        }

        public static void Counter(int countAll)
        {
            for (int i = 0; i < countAll; i++)
            {
                double x = RandomTo1();
                double y = RandomTo1();

                if (Math.Sqrt(Math.Pow(x,2)) + Math.Pow(y,2) <=1)
                {
                    _countInCircle++;
                }
            }
            
            double pi = 4 * (double)_countInCircle/countAll;
            Console.WriteLine($"Pi = {pi}");

        }
    }
}