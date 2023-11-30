using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class EllipseTests //: IDisposable
    {
        // public void Dispose()
        // {
        //     Ellipse.ClearAllEllipses();
        // }

       
        // First Test: Our test will confirm we can successfully create an ellipse object with 2 radius values
        [TestMethod]
        public void EllipseConstructor_CreatesInstanceOfEllipse_Ellipse()
        {
            Ellipse newEllipse = new Ellipse(2, 3);
            Assert.AreEqual(typeof(Ellipse), newEllipse.GetType());

        }

        // 2nd test: Adding get functionality to our 1st private fields

        [TestMethod]
        public void GetRadius1_ReturnsRadius1ValueInEllipse_Int()
        {
            // Arrange
            int myRadiusVal1 = 7;
            Ellipse myEllipse = new Ellipse(myRadiusVal1, 20);

            // Act
            int result = myEllipse.RadiusVal1;

            // Assert
            Assert.AreEqual(myRadiusVal1, result);
        }

        // 3rd test: Adding set functionality to our 1st private fields
         [TestMethod]
        public void SetRadius1_SetsValueForRadius1InEllipse_void()
        {
            // Arrange
            int myRadiusVal1 = 77;
            Ellipse myEllipse = new Ellipse(myRadiusVal1, 20);

           // Act
           myEllipse.RadiusVal1 = myRadiusVal1;

            // Assert
            Assert.AreEqual(myRadiusVal1, myEllipse.RadiusVal1);
        }

        [TestMethod]
        public void GetRadius2_ReturnsRadius1ValueInEllipse_Int()
        {
            // Arrange
            int myRadiusVal2 = 7;
            Ellipse myEllipse = new Ellipse(1, myRadiusVal2);

            // Act
            int result = myEllipse.RadiusVal2;
            
            // Consider adding debugging information to your test to print or log the state of the Ellipse object before the assertion. This can help you understand the state of the object during the test. Thats what I did below
            Console.WriteLine($"RadiusVal2: {myEllipse.RadiusVal2}");

            // Assert
            Assert.AreEqual(myRadiusVal2, result);
        }

          [TestMethod]
            public void SetRadius2_SetsValueForRadius2InEllipse_void()
            {
                // Arrange
                int myRadiusVal2 = 77;
                Ellipse myEllipse = new Ellipse(myRadiusVal2, 20);

                // Act
                myEllipse.RadiusVal2 = myRadiusVal2;

                // Assert
                Assert.AreEqual(myRadiusVal2, myEllipse.RadiusVal2);
            }        

        // [TestMethod]
        // public void AreaOfEllipse_CalculatesAreaOfEllipse_Double()
        // {
        //     // Arrange
        //     int myRadiusVal2 = 7;
        //     Ellipse myEllipse = new Ellipse(1, myRadiusVal2);
        //     double piValue = 3.1415926535897931;


        //     // Act
        //     double result = myEllipse.AreaOfEllipse();
        //     double myAreaValue = piValue * 1 * myRadiusVal2;
            
        //     // Assert
        //     Assert.AreEqual(myAreaValue, result);
        // }

        [TestMethod]
            public void GetPi_ReturnsValueOfPi_Double()
            {
            // Arrange
            double piVal = 3.1415926535897931;
            Ellipse newEllipse = new Ellipse(2, 3);
            // Act
            double result = newEllipse.GetPiVal();
            // Assert
            Assert.AreEqual(piVal, result);
            }






    }

}