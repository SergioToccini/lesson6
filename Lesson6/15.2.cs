using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson6
{
    public class FifteenDotTwo
    {
        public void FifteenDotTwoSolution()
        {
            var cards = new Dictionary<int, string>();
            cards.Add(1,"Spades");
            cards.Add(2,"Clubs");
            cards.Add(3,"Diamonds");
            cards.Add(4,"Hearts");

            Console.WriteLine("Please enter your number (1-4)");
            var input = Console.Read();
            bool check = (CharUnicodeInfo.GetDecimalDigitValue((char)input) > 0 && CharUnicodeInfo.GetDecimalDigitValue((char)input) <= 4);
            if (check)
            {
                Console.WriteLine(cards[CharUnicodeInfo.GetDecimalDigitValue((char)input)]);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}