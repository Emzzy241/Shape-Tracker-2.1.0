// Since each of these classes are a part of our Shape Tracker models, we should also add each new class to the ShapeTracker.Models namespace:
using System;
using System.Collections.Generic;


namespace ShapeTracker.Models
{
  public class Ellipse
  {
    // Ellipse code here.

    private int _radiusVal1;
    private int _radiusVal2;

    public Ellipse(int radVal1, int radVal2)
    {
        _radiusVal1 = radVal1;
        _radiusVal2 = radVal2;
    }

    public int RadiusVal1
    {
      get { return _radiusVal1; }
      set { _radiusVal1 = value; }
    }



  }
}