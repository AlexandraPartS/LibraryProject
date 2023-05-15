using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary;

public class Triangle : Shape
{
    private double[] sides;
    public double[] Sides
    {
        get
        { 
            return sides; 
        }
        set
        {
            foreach (var side in value)
            {
                DataValidation.CheckPozitive(side);
                DataValidation.CheckExceedingPossibleValue(side);
                DataValidation.CheckTriangleSideSum(side, value);
            }
            DataValidation.CheckExceedingTheResultForOperationsWithValues(value);
            sides = value;
        }
    }

    public Triangle(double a, double b, double c) => Sides = new double[] { a, b, c };

    public override double GetArea()
    {
        double p = (Sides.Sum()) / 2;
        return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
    }

    //Task 1.4
    public bool IsRegularTriangle()
    {
        Array.Sort(Sides);
        return Sides[2] == Math.Sqrt(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2));
    }

    public override string DataShow()
    {
        return base.DataShow() + $"Sides: [{String.Join(", ", this.Sides)}]\n";
    }    
    public string DataShow(string plusIsRight)
    {
        return base.DataShow() + $"Sides: [{String.Join(", ", this.Sides)}] \nIs Right: {this.IsRegularTriangle()}\n";
    }

}
