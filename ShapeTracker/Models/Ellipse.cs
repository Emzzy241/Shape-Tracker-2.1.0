// Since each of these classes are a part of our Shape Tracker models, we should also add each new class to the ShapeTracker.Models namespace:
using System;
using System.Collections.Generic;


namespace ShapeTracker.Models
{
  public class Ellipse
  {
    // Ellipse code here.

    private int _radiusVal1;
    // private int _radiusVal2;

    public Ellipse(int radVal1, int radVal2)
    {
        _radiusVal1 = radVal1;
        RadiusVal2 = radVal2;
    }

    public int RadiusVal1
    {
      get { return _radiusVal1; }
      set { _radiusVal1 = value; }
    }

    public int RadiusVal2 { get; set; }
    
    private double _pi = 3.1415926535897931;

    public double GetPiVal()
    {
        return _pi;
    }

    // Pi is a constant, no setter was needed because I do not want to set the value for a constant


    public double AreaOfEllipse()
    {
      double myPi = GetPiVal();
      return myPi * RadiusVal1 * RadiusVal2;
    }





  }
}