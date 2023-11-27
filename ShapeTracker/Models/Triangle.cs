// 

namespace ShapeTracker.Models
{
  public class Triangle
  {
    private int _side1;

    public int Side1 
    {
       get { return _side1; }
       set { _side1 = value; }
    }
    
    
    

    // Adding a simple constructor, we are explicitly defining our constructor, Immediately we do this, C£ takes the costructor it implicitly created for us when we created an empty class
    public Triangle(int length1)
    {
        _side1 = length1;
    }


  }
}



































// We have 2 namespaces in our application: one for UI logic and 1 for business logic
// // The business logic namespace's name is ShapeTracker.Models becuase it will hold all of the classes that contain our business logic
// // The list we made use of is a collection and its a special type of Collection named: Generic... Hence, we need to include using System.Collections.Generic;
// // The list lives inside the System.Collection.Generic

// using System;
// using System.Collections.Generic;
// namespace ShapeTracker.Models
// {
        
//     public class Triangle
//     {
//         // Code for business logic goes here

//         private int _side1;

//         // Adding a property for _side1 field for DRY purposes
        
//         public int Side1
//         {
//             get { return _side1; }
//             set { _side1 = value; }

//         }


//         // private int Side2; -- commenting this out, cause we did 3 things in 1 line, all thanks to auto-implemented properties
//         private int _side3;

//         // creatig a static class(for lists that will help i listig out all our triangles)... This static field does not need to be reinstantiated with the new keyword at all. Its just like(Cosole.WriteLine()... Console is a static class and WriteLine() is a static method that gets called on the class itself and not an instance of the class)
//         // don't forget: the naming convention for a private field is: _lowerCamelCasing

//         private static List<Triangle> _instances = new List<Triangle> {};
 
//         // creating my constructor now

//         public Triangle(int length1, int length2, int length3)
//         {
//             _side1 = length1;
//             Side2 = length2;
//             _side3 = length3;
//             // We made use of this within our constructor to reference the object instance that is being created
//             _instances.Add(this);

//         }

//         // Using a auto-implemented property: a eve shorter shortcut to: 1. create a private field, 2. a public property and 3. create a get and set actions to access the private fields all in oneline
//         public int Side2 { get; set; }

//         // Writig Getter methods that can help in getting information
//         // public int GetSide1()
//         // {
//         //     return _side1;
//         // }

//         // public int GetSide2()
//         // {
//         //     return Side2;
//         // }

//         public int GetSide3()
//         {
//             return _side3;

            
//         }
//             // Adding setter methods... Note: since we wont be returning any object here, we make use of the return type void: TO tell C# we are writing a method whose return type is nothing(void)

//             // public void SetSide1(int newSide)
//             // {   
//             //     _side1 = newSide;
//             // }

//             // public void SetSide2(int newSide)
//             // {
//             //     Side2 = newSide;
//             // }

//             public void SetSide3(int newSide)
//             {
//                 _side3 = newSide;
//             }







//         // Writing a method for the constructor
//         public string CheckType()
//         {
//             if((_side1 > (Side2 + _side3) && ((Side2 > (_side1 + _side3)) && (_side3 > (_side1 + Side2)))))
//             {
//                 return "It is not a triangle";
//             }
            
//             else if((_side1 != Side2) && ((_side1 != _side3)) && ((_side3 != Side2)))
//             {
//                 return "It is a scalene traingle";
//             }
//             else if((_side1 == Side2) && ((Side2 == _side3)) && ((_side1 == _side3)))
//             {
//                 return "It is an equilateral triangle";
//             }

//             else
//             {
//                 return "It is an isoceles triangle";
//             }
            
//         }

//         // Starting from the known to the unknown

//         // public object isScalene(Side1, Side2, Side3)
//         // {
//         //     if((Side1 != Side2) && (Side2 != Side3))
//         //     {
//         //         return "It is a scalene Triangle";
//         //     }
//         // }



//         // The static getter method that returns _instances(our list of triangle objects)
//         public static List<Triangle> GetAll()
//         {
//             return _instances;
//         }

//         // The Triangle.ClearAll() method that helps to clear all triangle objects from the list
//         public static void ClearAll()
//         {
//             _instances.Clear();
//         }

//     }
// }
