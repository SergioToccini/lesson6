using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson6
{
    public class FifteenDotFive
    {
        private int _input;
        public void FifteenDotFiveSolution(int input)
        {
            _input = input;
            var cards = new Dictionary<int, string>();
            cards.Add(1,"Spades");
            cards.Add(2,"Clubs");
            cards.Add(3,"Diamonds");
            cards.Add(4,"Hearts");
            
            bool check = (_input > 0 && _input <= 4);
            if (check)
            {
                Console.WriteLine(cards[_input]);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}