using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public virtual string DataShow() => $"Shape: {this.GetType().Name}\nArea: {this.GetArea():F3}\n";



        ///<summary>
        ///Task 1.3: Calculating the area of a shape without knowing the type of the shape at compile time
        ///1) Formula Newton-Leibniz - integral
        ///2) Picks Formula: for a figure built on a sheet in a cage
        ///     М – number of nodes on the border of the triangle (on sides and vertices)
        ///     N – number of nodes inside the triangle
        ///     *By "nodes" we mean the intersection of lines.
        ///</summary>
        public static double GetAreaFormulaNewtonLeibniz(Function f1, Function f2, double a, double b)
        {
            double sum1 = 0.0, sum2 = 0.0;
            //Loop to calculate area for functions
            return Math.Abs(sum1 - sum2);
        }
        public delegate double Function(double x);

        public static double GetAreaFormulaByPicks(uint M, uint N) => Math.Round(((double)M / 2 + N - 1), 3);

    }
}
