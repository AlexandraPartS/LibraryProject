using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public static class DataValidation
    {

        public static List<ArgumentException> exceptions = new List<ArgumentException>()
        {
            new ArgumentException("Numerical value shoud be positive."),//case 1: <= 0
            new ArgumentException("Incorrect values: the sum of the lengths of any two sides of a triangle is greater than the length of the remaining side."),//case 2: a + b < c
            new ArgumentException("Too big values: calculations exceed Double.Maxvalue value.")//case 3: Math.Pow(a + b + c, x) > Double.Maxvalue
        };

        public static void BaseCheck(double value)
        {
            if (value <= 0) throw exceptions[0]; 
        }

        internal static void CheckTriangleSide(double value, double[] arr)
        {
            if(arr.Length == 3)
            {
                if (arr.Sum() - 2 * value <= 0) throw exceptions[1];
            }
        }

        public static void ExceedingValue(double value)
        {
            if (Double.IsPositiveInfinity(Math.Pow(value, 1))) throw exceptions[2];
        }

        public static void ExceedingValue(double[] arr)
        {
            var p = arr.Sum();
            if (Double.IsPositiveInfinity( Math.Pow(p,1))) throw exceptions[2];
            else if (Double.IsPositiveInfinity(Math.Pow(p,2))) throw exceptions[2];
            else if (Double.IsPositiveInfinity( Math.Pow(p,3))) throw exceptions[2];
        }

    }

}
