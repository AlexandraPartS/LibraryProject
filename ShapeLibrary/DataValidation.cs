using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    internal static class DataValidation
    {

        public static List<ArgumentException> exceptions = new List<ArgumentException>()
        {
            new ArgumentException("Numerical value shoud be positive."),//case 1: <= 0
            new ArgumentException("Too big value: exceed Double.Maxvalue value."),//case 2: Math.Pow(a + b + c, x) > Double.Maxvalue
            new ArgumentException("Incorrect values: the sum of the lengths of any two sides of a triangle is greater than the length of the remaining side."),//case 3: a + b < c
            new ArgumentException("Too big values: calculations exceed Double.Maxvalue value.")//case 4: Math.Pow(a + b + c, x) > Double.Maxvalue
        };

        public static void CheckPozitive(double value)
        {
            if (value <= 0) throw exceptions[0]; 
        }

        public static void CheckExceedingPossibleValue(double value)
        {
            if (Double.IsPositiveInfinity(Math.Pow(value, 1))) throw exceptions[1];
        }

        internal static void CheckTriangleSideSum(double value, double[] arr)
        {
            if(arr.Length == 3)
            {
                if (arr.Sum() - 2 * value <= 0) throw exceptions[2];
            }
        }

        public static void CheckExceedingTheResultForOperationsWithValues(double[] arr)
        {
            var p = arr.Sum();
            for(int i = 2; i < arr.Length; i++)
            {
                if(Double.IsPositiveInfinity(Math.Pow(p, i))) throw exceptions[3];
            }
        }

    }

}
