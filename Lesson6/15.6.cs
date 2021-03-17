using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson6
{
    public class FifteenDotSix
    {
        private int _input2;
        public void FifteenDotSixSolution(int input2)
        {
            _input2 = input2;
            var cards = new Dictionary<int, string>();
            cards.Add(6,"6");
            cards.Add(7,"7");
            cards.Add(8,"8");
            cards.Add(9,"9");
            cards.Add(10,"10");
            cards.Add(11,"Jack");
            cards.Add(12,"Queen");
            cards.Add(13,"King");
            cards.Add(14,"Ace");
            
            bool check = (_input2 > 5 && _input2 <= 14);
            if (check)
            {
                Console.WriteLine(cards[input2]);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}