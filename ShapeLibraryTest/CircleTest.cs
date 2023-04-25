using ShapeLibrary;

namespace ShapeLibraryTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Numerical value shoud be positive.")]
        public void Test_DoesNot_DataValidation_PositiveValue()
        {
            Circle circle = new Circle(-2);
        }

        [TestMethod]
        public void Test_DataValidation_PositiveValue()
        {
            Circle circle = new Circle(2);
            Assert.AreEqual(2, circle.Radius );
        }

        [TestMethod]
        public void Test_GetArea()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Circle circle = new Circle(12.2);
            Assert.AreEqual("467.595", $"{circle.GetArea():F3}");
        }

    }
}