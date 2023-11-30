// Since each of these classes are a part of our Shape Tracker models, we should also add each new class to the ShapeTracker.Models namespace:
using System;
using System.Collections.Generic;


namespace ShapeTracker.Models
{
  public class Rectangle
  {
    private int _rectSide1;

    // Auto-Implemented property for Side2
    public int Side2 { get; set; }

    // The List of all our Rectanglesgles, it will be a private and static field
    private static List<Rectangle> _rectInstances = new List<Rectangle>() {};
    
    // Constructor
    public Rectangle(int length1, int length2)
    {
      _rectSide1 = length1;
      Side2 = length2; 
      _rectInstances.Add(this);
    }

    // A public getter method that can help to access my private static field()
    public static List<Rectangle> GetAllRectangles()
    {
      return _rectInstances;
    }

    // A setter method that can help in clearing out my rectangle list
    // public static void ClearAllRectangles()
    // {
    //   return _returnInstances
    // }


    // A property for Side1
    public int Side1
    {
      get { return _rectSide1; }
      set { _rectSide1 = value; }
    }

    // Method to calculate Area of Rectangle
    public int AreaOfRectangle()
    {
        return Side1 * Side2;
    }
    
    // ClearAllRectagles
    public static void ClearAllRectangles()
    {
      _rectInstances.Clear();
    }
    
  }

  // The static GetAll() method
  // public List<Rectangle> GetAllRectangles
}