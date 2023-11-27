

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

//  we include the attribute [TestMethod] to identify this method as a test, similar to how we list [TestClass] above our TriangleTests class in order to identify it as a class of tests.

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {

    // First Test: Our test will confirm Triangle objects of the Triangle type can be created successfully.
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {

      Triangle newTriangle = new Triangle(2);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    // Second Test: So the next simplest behavior we'll tackle is creating a get action for the first side of a triangle. In terms of code, we'll create a private field called _side1, which we'll access through the get action of a public property called Side1.
    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1);
      // Act
      int result = newTriangle.Side1;
      // Assert
      Assert.AreEqual(length1, result);
    }

    // Third test: We want to be able to get and set side for our private field _side1. We have done for getting, its time for setting
    

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3);
      int newLength1 = 44;
      // Act
      newTriangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

  }
}