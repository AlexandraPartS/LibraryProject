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
                DataValidation.BaseCheck(side);
                DataValidation.CheckTriangleSide(side, value);
            }
            DataValidation.ExceedingValue(value);
            sides = value;
        }
    }

    //public Triangle(double a, double b, double c) => Sides = new double[] { a, b, c };

    public Triangle(params double[] numbers)
    {
        if (numbers.Length == 3) Sides = numbers ;
    }

    public override double GetArea()
    {
        double p = (Sides.Sum()) / 2;
        return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
    }

    //Task 1.4
    public bool IsRight()
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
        return base.DataShow() + $"Sides: [{String.Join(", ", this.Sides)}] \nIs Right: {this.IsRight()}\n";
    }

}
