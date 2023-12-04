using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class RectangleTests : IDisposable
    {
        // This helps to clear each test as I progress
        public void Dispose()
        {
            Rectangle.ClearAllRectangles();
        }

        // First Test: Our test will confirm Rectangle objects of the Rectangle type can be created successfully.
        [TestMethod]
        public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
        {
            Rectangle newRectangle = new Rectangle(2, 3);
            Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
        }

        // Second Test": Next simplest  behaviour: creating a get action for the first side of a rectangle. In terms of code, we'll create a private field called _side1, which we'll access through the get action of a public property called Side1.

        [TestMethod]
        public void GetSide1_ReturnsSide1InRectangle_Int()
        {
            // Arrange: Gathering, declaring, and creating all necessary components for the test.
            int length1 = 7;
            Rectangle newRectangle = new Rectangle(length1, 2);
           
           // Act:Invoking(calling) the fuctionality we're testing, often by calling a method or retrieving a property.
           int result = newRectangle.Side1;

            // Assert: We confirm the functionality works as expected by comparing its anticipated(expected) output with the actual output
            Assert.AreEqual(length1, result);
        }

        // Third Test": Next simplest  behaviour: creating a set action for the first side of a rectangle. In terms of code, we'll create a private field called _side1, which we'll access through the get action of a public property called Side1.

        [TestMethod]
        public void SetSide1_SetsValueForSide1InRectangle_void()
        {
            // Arrange: Gathering, declaring, and creating all necessary components for the test.
            int newLength1 = 7;
            Rectangle newRectangle = new Rectangle(newLength1, 2);
           
           // Act:Invoking(calling) the fuctionality we're testing, often by calling a method or retrieving a property.
           newRectangle.Side1 = newLength1;

            // Assert: We confirm the functionality works as expected by comparing its anticipated(expected) output with the actual output
            Assert.AreEqual(newLength1, newRectangle.Side1);
        }

        // Fourth Test": Next simplest  behaviour: creating a get action for the second side of a rectangle. We are testing an auto-implemented property here

        [TestMethod]
        public void GetSide2_ReturnsSide2InRectangle_Int()
        {
            // Arrange: 
            int length2 = 77;
            Rectangle newRectangle2 = new Rectangle(2, length2);
           
           // Act:
           int result = newRectangle2.Side2;

            // Assert: 
            Assert.AreEqual(length2, result);
        }

         // Fifth Test": Next simplest  behaviour: creating a set action for the second side of a rectangle.

        [TestMethod]
        public void SetSide2_SetsValueForSide2InRectangle_void()
        {
            // Arrange
            int newLength2 = 72;
            Rectangle newRectangle = new Rectangle(2, newLength2);
           
           // Act
           newRectangle.Side2 = newLength2;

            // Assert
            Assert.AreEqual(newLength2, newRectangle.Side2);
        }




        // Sixth Test": Testing method for calculating area of rectangle

        [TestMethod]
        public void AreaOfRectangle_FindsAreaOfARectangle_Int()
        {
            // Arrange: 
            int length2 = 77;
            Rectangle newRectangle2 = new Rectangle(2, length2);
           
           // Act:
           int result = newRectangle2.AreaOfRectangle();
           int myArea = 2 * length2;

            // Assert: 
            Assert.AreEqual(myArea, result);
        }

        // Eight Test: Test to get all rectagles created and their areas
    [TestMethod]
    public void GetAll_ReturnsAllTriangleInstances_List()
    {
      // Arrange
      Rectangle rect1 = new Rectangle(2, 2);
      Rectangle rect2 = new Rectangle(21, 3);
      Rectangle rect3 = new Rectangle(1, 3);
      List<Rectangle> expected = new List<Rectangle> { rect1, rect2, rect3 };
      // Act
      List<Rectangle> actualResult = Rectangle.GetAllRectangles();
      // Assert
      CollectionAssert.AreEqual(expected, actualResult);
    }

     [TestMethod]
    public void ClearAll_DeletesAllRectangleInList_Void()
    {
      // Arrange
      Rectangle rect1 = new Rectangle(2, 2);
      Rectangle rect2 = new Rectangle(21, 3);
      Rectangle rect3 = new Rectangle(1, 3);
      List<Rectangle> expected = new List<Rectangle> { };
      // Act
      Rectangle.ClearAllRectangles();
      // Assert
      CollectionAssert.AreEqual(expected, Rectangle.GetAllRectangles());
    }

    // Done with writing  testing the business logic, now its time to implement the UserInterface functionality
    


        
    }
}