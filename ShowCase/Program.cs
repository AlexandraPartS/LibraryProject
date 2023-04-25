using ShapeLibrary;
try
{

    //Task 1
    Circle circle = new Circle(2.2);
    Console.WriteLine(circle.DataShow());

    Triangle triangle = new Triangle(4, 5, 6);
    Console.WriteLine(triangle.DataShow("isRight"));

    //Task 1.2
    Rectangle square = new Rectangle(5, 2, 5, 2);
    Console.WriteLine(square.DataShow());


    //Task 1.3
    //Var1. Formula Newton-Leibniz
    double a = 0, b = 3, result;
    static double f1(double x) => (x+2);
    static double f2(double x) => 1;
    result = Shape.GetAreaFormulaNewtonLeibniz(f1, f2, a, b);
    Console.WriteLine("result = {0}", result);
    //Var2.Picks Formula
    Console.WriteLine(Shape.GetAreaFormulaByPicks(15, 34));

}
catch (Exception e) 
{ 
    Console.WriteLine(e.Message); 
}

// The example displays output like the following:
//Shape: Circle
//Area: 15,205
//Radius: 2,2

//Shape: Triangle
//Area: 9,922
//Sides: [4, 5, 6]
//Is Right: False

//Shape: Rectangle
//Area: 10,000
//Sides: [5, 2, 5, 2]

//result = 0

//40,5





/// <summary>
/// Task 1.4: Easy to Add Other Shapes.
/// Rectangle example (same for square,Rhombus, Parallelogram)
/// </summary>
class Rectangle : Triangle
{
    public Rectangle(params double[] numbers) : base(numbers)
    {
        if(numbers.Length == 4) Sides = numbers;
    }
    public override double GetArea() => Sides.Max() * Sides.Min();
}
