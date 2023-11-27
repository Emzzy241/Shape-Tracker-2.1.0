using System;
using ShapeTracker.Models;
using ShapeTracker.UserInterfaceModels;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
        // Calling my welcome property from my banners class
        // Do't forget the auto-implemented property we added there... Its a property, not a method
    //     Console.WriteLine(WelcomeBanner.Welcome);

    //     Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
        
    //     // Taking in the inputs from my users

    //             Console.WriteLine("Please enter a number");
    //             string stringNumber1 = Console.ReadLine();

    //             Console.WriteLine("Enter another number");
    //             string stringNumber2 = Console.ReadLine();

    //             Console.WriteLine("Enter a third number");
    //     string stringNumber3 = Console.ReadLine();

    //     // Console.ReadLine(); taskes in a string, we need to make use of int.Parse() to change it to an integer

    //     int firstSide = int.Parse(stringNumber1);
    //     int secondSide = int.Parse(stringNumber2);
    //     int thirdSide = int.Parse(stringNumber3);

    //     // Making a new instance of the tringle so I can input all of me 3 sides in it
    //     Triangle tri = new Triangle(firstSide, secondSide, thirdSide);
    
    //     // NOTE: Any new method we create in our Program class(that contains our UI logic) should be static. We dont want to have to create an instance of the Program class in order to call the method.
    //     // Calling the static ConfirmOrEditTriangle() method
    //     ConfirmOrEditTriangle(tri);
    // }

    // // Writing the Static ConfirmOrEditTriangle() method

    // static void ConfirmOrEditTriangle(Triangle tri)
    // {
    //     // Its a static and a void method
    //     // code to confirm the sides of our triangle will go here

    //     Console.WriteLine("Please confirm that you entered in your triangle correctly:");
    //     Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
    //     Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
    //     Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
    //     Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
    //     string userInput = Console.ReadLine();  

    //      if (userInput == "yes")
    //         {
    //             // We can easily add the code here to check the type of the triangle, but we want to practice a good separation of concern; edit functionality is different form triangle type checking functionality, hence we separate them into different methods

    //             CheckTriangleType(tri);
    //         }
    //         else
    //         {
    //             Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
    //             Console.WriteLine("Please enter a number:");
    //             string stringNumber1 = Console.ReadLine();  
    //             Console.WriteLine("Enter another number:");
    //             string stringNumber2 = Console.ReadLine();  
    //             Console.WriteLine("Enter a third number:");
    //             string stringNumber3 = Console.ReadLine();  
    //             tri.Side1 = int.Parse(stringNumber1);  
    //             tri.Side2 = int.Parse(stringNumber2);  
    //             tri.SetSide3(int.Parse(stringNumber3)); 
    //             ConfirmOrEditTriangle(tri);

    //             // In any case, keep in mind that you can create a loop by calling on the same method you are declaring within its own definition (eg: calling ConfirmOrEditTriangle() within the ConfirmOrEditTriangle() definition)
    //         }
    //     }

    //     // Like other UI methods, the CheckTriangleType() method is static so that we can call it on the class and not the instance... This is important for the method to work as expected
    //     // How this UI method works: we call on the instance method Triangle.CheckType() to determine the type of the triangle

    //     static void CheckTriangleType(Triangle tri)
    //     {
    //         string result = tri.CheckType();
    //         Console.WriteLine("-----------------------------------------");
    //         Console.WriteLine("Your result is: " + result + ".");
    //         Console.WriteLine("-----------------------------------------");
    //         Console.WriteLine("What's next?");
    //         Console.WriteLine("Would you like to check a new triangle (new)?");
    //         // PrintAllTriangles();
    //         Console.WriteLine("Please enter 'new' to check the type of a new triangle. Enter 'all' to print out all triangles To exit, enter any key.");
    //                     string userResponse = Console.ReadLine(); 
    //         if (userResponse == "new" || userResponse == "New")
    //         {
    //             // We are looping back to the start of our program 
    //             Main();
    //         }
    //         else
    //         {
    //             Console.WriteLine("Goodbye!");
    //         }
        }

        // Writing the functionalities for printing all triangles and to clear all the triangles.

        // For printing all triangles
        // static void PrintAllTriangles(Triangle tri)
        // {
        //     Triangle myTri = tri.GetAll();
        //     Console.WriteLine("Here is the list of Triangles you have created");
        //     Console.WriteLine("-----------------------------------------");
        //     Console.WriteLine("Your result is: " + myTri + ".");
        //     Console.WriteLine("-----------------------------------------");
            
        // }





  }
}
























        //     Console.WriteLine("Hello, welcome to the Advanced ShapeTracker :) ");
        //     Console.WriteLine();
        //     Console.WriteLine("First off, Triangles");
        //     Console.WriteLine();

        //     // ShapeTracker.Models.Triangle testTriangle = new ShapeTracker.Models.Triangle();
        //     // SInce I have imported the ShapeTracker.Models, I can now make use of Triangle class

        //     // Scaling the application now, Now I want to seek the 3 triangle lengths from my user
        //     Console.WriteLine("Enter the value of the first side");
        //     string stringFirstSide = Console.ReadLine();
        //     int intFirstSide = int.Parse(stringFirstSide);
        //     Console.WriteLine();
            
        //     Console.WriteLine("Enter the value of the second side");
        //     string stringSecondSide = Console.ReadLine();
        //     int intSecondSide = int.Parse(stringSecondSide);
        //     Console.WriteLine();
            
        //     Console.WriteLine("Enter the value fo the third side");
        //     string stringThirdSide = Console.ReadLine();
        //     int intThirdSide = int.Parse(stringThirdSide);

        //     Triangle testTriangle = new Triangle(intFirstSide, intSecondSide, intThirdSide);


        //     Console.WriteLine();
        //     Console.WriteLine();
        //     Console.WriteLine($"The value for Side 1 is {testTriangle.Side1}");
        //     Console.WriteLine($"The value for Side 2 is {testTriangle.Side2}");
        //     Console.WriteLine($"The value for Side 3 is {testTriangle.Side3}");

        //     Console.WriteLine();
        //     Console.WriteLine();
        //     Console.WriteLine(testTriangle.CheckType());
//         }
//     }
// }