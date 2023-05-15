namespace ShapeLibrary
{

    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get
            { 
                return radius; 
            }
            set
            {
                DataValidation.CheckPozitive(value);
                DataValidation.CheckExceedingPossibleValue(value);
                radius = value;
            }
        }

        public Circle(double radius) => Radius = radius;


        public override double GetArea() => Radius * Radius * Math.PI;

        public override string DataShow()
        {
            return base.DataShow() + $"Radius: {this.Radius}\n";
        }

    }
}