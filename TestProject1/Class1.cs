﻿using System.Xml.Linq;

namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if (firstAngle + secondAngle + thirdAngle ==  180)// my name is (Badal)  I KILLED mutant in this line CHANGE 
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            
            return result;
        }
    }
}