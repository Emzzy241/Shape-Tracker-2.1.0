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

        


    }

}