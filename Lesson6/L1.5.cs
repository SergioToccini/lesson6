using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson6
{
    public class LOneDotFive
    {
        private bool _a = true;
        private bool _b = false;
        private bool _c = false;
        
        
        public void LOneDotFiveSolutionSolution()
        {
            bool resultA = _a != _b || _a != _c;
            Console.WriteLine(resultA);
            
            bool resultB = _a != true && _b != false;
            Console.WriteLine(resultB);
            
            bool resultC = (_a != true && _c != false) || _b == false;
            Console.WriteLine(resultC);
            
            bool resultD = _a == true && _b != false && _c != false;
            Console.WriteLine(resultD);
            
            bool resultG = _a == true && (_b != false && _c != false);
            Console.WriteLine(resultG);  
            
            bool resultE = _a == true || (_b != false && _c != false);
            Console.WriteLine(resultE);            

        }
    }
}