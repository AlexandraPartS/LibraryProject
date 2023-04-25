﻿using ShapeLibrary;

namespace ShapeLibraryTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Numerical value shoud be positive.")]
        public void Test_DoesNot_DataValidation_PositiveValue2()
        {
            Triangle triangle = new Triangle(2, -3, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Incorrect values: the sum of the lengths of any two sides of a triangle is greater than the length of the remaining side.")]
        public void Test_Not_DataValidation_CorrectLengthSide()
        {
            Triangle triangle = new Triangle(2, 3, 6);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Too big values: calculations exceed Double.Maxvalue value.")]
        public void Test_DoesNot_DataValidation_ExceedingValue()
        {
            Triangle triangle = new Triangle(1.3407807929942596E+154, 1.3407807929942596E+154, 2);
        }

        [TestMethod]
        public void Test_GetArea2()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Triangle triangle = new Triangle(4, 5, 6);
            Assert.AreEqual("9.922", $"{triangle.GetArea():F3}");
        }

        [TestMethod]
        public void Test_IsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool result = triangle.IsRight();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test_DoesNot_IsRight()
        {
            Triangle triangle = new Triangle(4, 5, 6);
            bool result = triangle.IsRight();
            Assert.IsFalse(result);
        }

    }
}