using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

//  we include the attribute [TestMethod] to identify this method as a test, similar to how we list [TestClass] above our TriangleTests class in order to identify it as a class of tests.

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests : IDisposable
  {

    public void Dispose()
    {
      Triangle.ClearAll();
    }

    // All of our tests are public methods: This allows the tools runningour tests to access them
    // All of our test are void methods: Meaning they do not return any thing; Never forget, a method in C# must return something

    // First Test: Our test will confirm Triangle objects of the Triangle type can be created successfully.
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {

      Triangle newTriangle = new Triangle(2, 3, 8);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    // Second Test: So the next simplest behavior we'll tackle is creating a get action for the first side of a triangle. In terms of code, we'll create a private field called _side1, which we'll access through the get action of a public property called Side1.
    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      // Arrange
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 2, 8);
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
      Triangle newTriangle = new Triangle(3, 3, 8);
      int newLength1 = 44;
      // Act
      newTriangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

    // Fourth Test: We want to test the get feature of a public auto-implemented property called Side2

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      // Arrange
      int length2 = 3;
      Triangle newTriangle = new Triangle(2, length2, 8);
      // Act
      int result = newTriangle.Side2;
      // Assert
      Assert.AreEqual(length2, result);
    }

    // Fifth Test: Adding and testing a set to our auto-implemented property.

     [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3,4, 8);
      int newLength2 = 6;
      // Act
      newTriangle.Side2 = newLength2;
      // Assert
      Assert.AreEqual(newLength2, newTriangle.Side2);
    }

    // Sixth Test: The next simplest behavior we'll tackle is creating a get action for the third side of a triangle. In terms of code, for our third side we'll create a private field called _side3, and we'll need to create a getter method called GetSide3() in order to access it.

    [TestMethod]
    public void GetSide3_ReturnsSide3_Int()
    {
      // Arrange
      int length3 = 55;
      Triangle newTriangle = new Triangle(2, 3, length3);
      // Act
      int result = newTriangle.GetSide3();
      // Assert
      Assert.AreEqual(length3, result);
    }

    // Seventh Test: Testing the private field _side3 through its setter method SetSide3()
  
  
    [TestMethod]
    public void SetSide3_SetsValueOfSide3_Void()
    {
      // Arrage, Act, Assert are easy orgaizational tricks that helps demystify the testing process and keep our testig clean. They basically keep our test process simple and easy.

      // Arrange --> Gathering, declaring, and creating all necessary componenets for the test
      Triangle newTriangle = new Triangle(3, 4, 8);
      int newLength3 = 8;
      
      // Act --> Invoking(calling) the fuctionality we're testing, often by calling a method or retrieving a property.
      newTriangle.SetSide3(newLength3);
      
      // Assert --> We confirm the functionality works as expected by comparing its anticipated(expected) output with the actual output
      // Assert.AreEqual(newLength3, newTriangle.GetSide3());
      Assert.AreEqual(newLength3, newTriangle.GetSide3());

    }


    // Eight Test: Testing the "not a triangle" Path in the CheckType() Method

    [TestMethod]
    public void NotATriangle_ChecksIfItsNotATriangle_CheckType()
    {
      Triangle newTriangle = new Triangle(3, 4, 8);

      // Act --> Invoking(calling) the fuctionality we're testing, often by calling a method or retrieving a property.
      string triType =  newTriangle.CheckType();
      
      // Assert --> We confirm the functionality works as expected by comparing its anticipated(expected) output with the actual output
      Assert.AreEqual("not a triangle", triType);

    }

    // Ninth Test: Testing the "scalene triangle" Path in the CheckType() Method

    [TestMethod]
    public void ScaleneTriangle_ChecksIfItsScaleneTriangle_CheckType()
    {
      // Arrange
      Triangle scaleneTri = new Triangle(3, 4, 5);
      
      // Act
      string triType = scaleneTri.CheckType();
      
      // Assert
      Assert.AreEqual("scalene triangle", triType);
    
    }

    // Tenth test: Testing the "isosceles triangle" Path in the CheckType() Method

    [TestMethod]
    public void IsocelesTriangle_ChecksIfItsIsocelesTriangle_CheckType()
    {
      // Test for isoceles: when only two of the sides have the same length, but not the other.
      // Arrange
      Triangle isocelesTri = new Triangle(5, 4, 4);
      
      // Act
      string triType = isocelesTri.CheckType();
      
      // Assert
      Assert.AreEqual("isoceles triangle", triType);
    
    }

    // Eleveth Test: Testing the "equilateral triangle" Path in the CheckType() Method
    [TestMethod]
     public void EquilateralTriangle_ChecksIfItsEquilateralTriangle_CheckType()
    {
      // Test for isoceles: when all sides are equal
      // Arrange
      Triangle equilateralTri = new Triangle(4, 4, 4);
      
      // Act
      string triType = equilateralTri.CheckType();
      
      // Assert
      Assert.AreEqual("equilateral triangle", triType);
    
    }

    // Next: Testing the Private static field _instances through its getter and setter method GetAll()
    
    // Twelfth Test: Identifying the simplest possible behaviour the program must exhibit which is: creating our private static _instances field along with its getter method, GetAll()

    [TestMethod]
    public void GetAll_ReturnsAllTriangleInstances_List()
    {
      // Arrange
      Triangle tri1 = new Triangle(2, 2, 9);
      Triangle tri2 = new Triangle(21, 3, 9);
      Triangle tri3 = new Triangle(1, 3, 9);
      List<Triangle> expected = new List<Triangle> { tri1, tri2, tri3 };
      // Act
      List<Triangle> actualResult = Triangle.GetAll();
      // Assert
      CollectionAssert.AreEqual(expected, actualResult);
    
      // Our test still failed
      //Well, the issue is not obvious... In fact, our code and test are written perfectly, and the issue is in our tests: because the tests will run in order, by the time it gets to our final GetAll test, we've already many, many Triangle objects to our static list — 11 to be precise!

      // Remember that each time a new Triangle object is created by the constructor, the entire Triangle class has a new object added to its static List of Triangle objects. We can't reset the static list unless we manually clear the list (like with a static ClearAll() method)! So, when our GetAll test runs, it compares the expected list of 3 triangles with a list of 14 Triangle objects (11 from the previous tests and 3 from the GetAll test).

      // Well, we can solve this issue with a teardown method that will clear out _instances between each test. Let's learn how to do that in the next lesson!
      // To forcefully pass this test, we can comment out all of our previous tests and leave only the Last one(GetAll()), thats an awful way to solve the issue. Lets learn a new concept that will help us solve the error
    }

    // Thirteenth Test: Testing the Private Static Field _instances through its Setter Method ClearAll()

     [TestMethod]
    public void ClearAll_DeletesAllTriangleInList_Void()
    {
      // Arrange
      Triangle tri1 = new Triangle(2, 2, 9);
      Triangle tri2 = new Triangle(21, 3, 9);
      Triangle tri3 = new Triangle(1, 3, 9);
      List<Triangle> expected = new List<Triangle> { };
      // Act
      Triangle.ClearAll();
      // Assert
      CollectionAssert.AreEqual(expected, Triangle.GetAll());
    }


 
 
  }
}