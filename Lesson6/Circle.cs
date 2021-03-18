using System;

namespace Lesson6
{
    public static class Circle
    {
        private static readonly Random Random = new Random();

        private static int _countInCircle = 0;
        private static int _countAll = 0;
        
        private static double RandomTo1()
        {
            return Random.NextDouble();
        }

        public static void Counter(int countAll)
        {
            _countAll = countAll;
            for (int i = 0; i < _countAll; i++)
            {
                double x = RandomTo1();
                double y = RandomTo1();
                if (Math.Sqrt(Math.Pow(x,2))+Math.Pow(y,2) <=1)
                {
                    _countInCircle++;
                }
            }

            double pi = 4*(double) _countInCircle/_countAll;
            Console.WriteLine($"Pi = {pi}");

        }
    }
}