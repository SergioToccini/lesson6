using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            FifteenDotFive fifteenDotFive = new FifteenDotFive();
            FifteenDotSix fifteenDotSix = new FifteenDotSix();
            LOneDotFive lOneDotFive = new LOneDotFive();
            
            Console.WriteLine("Please enter your number (1-4)");
            var input = Convert.ToInt32(Console.ReadLine()); //int.Parse()
            fifteenDotFive.FifteenDotFiveSolution(input);
            
            Console.WriteLine("Please enter card number (6-14)");
            int input2 = Convert.ToInt32(Console.ReadLine());
            fifteenDotSix.FifteenDotSixSolution(input2);
            
            lOneDotFive.LOneDotFiveSolution();


            Console.WriteLine("Enter number of points");
            int countAll = Int32.Parse(Console.ReadLine());
            Circle.Counter(countAll);
            
        }
    }
}
