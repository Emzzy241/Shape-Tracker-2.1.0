using System;
using ShapeTracker.Models;
using ShapeTracker.UserInterfaceModels;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
        // Calling my welcome property from my banners class
        // Do't forget the auto-implemented property we added there... Its a property, not a method
        Console.WriteLine(WelcomeBanner.Welcome);

        Console.WriteLine("Welcome to the ShapeTracker application");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("To track Triangles, enter 't', to track rectangle enter 'r', to track ellipse enter 'e'. To end application enter k.");
        string userAns = Console.ReadLine().ToLower();

        switch (userAns)
        {
          case "t":
                  Console.WriteLine();
                  Console.WriteLine();
                  Console.WriteLine("Tracking Triangles");
                  
                  Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
              
                  // Taking in the inputs from my users

                Console.WriteLine("Please enter a number");
                string stringNumber1 = Console.ReadLine();

                Console.WriteLine("Enter another number");
                string stringNumber2 = Console.ReadLine();

                Console.WriteLine("Enter a third number");
                string stringNumber3 = Console.ReadLine();

                // Console.ReadLine(); taskes in a string, we need to make use of int.Parse() to change it to an integer

                int firstSide = int.Parse(stringNumber1);
                int secondSide = int.Parse(stringNumber2);
                int thirdSide = int.Parse(stringNumber3);

                // Making a new instance of the tringle so I can input all of me 3 sides in it
                Triangle tri = new Triangle(firstSide, secondSide, thirdSide);
            
                // NOTE: Any new method we create in our Program class(that contains our UI logic) should be static. We dont want to have to create an instance of the Program class in order to call the method.
                // Calling the static ConfirmOrEditTriangle() method
                ConfirmOrEditTriangle(tri);
  

    // Writing the Static ConfirmOrEditTriangle() method

                static void ConfirmOrEditTriangle(Triangle tri)
                {
                    // Its a static and a void method
                    // code to confirm the sides of our triangle will go here

                    Console.WriteLine("Please confirm that you entered in your triangle correctly:");
                    Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
                    Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
                    Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
                    Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides. ");
                    string userInput = Console.ReadLine().ToUpper();  

                    if (userInput == "YES")
                        {
                            // We can easily add the code here to check the type of the triangle, but we want to practice a good separation of concern; edit functionality is different form triangle type checking functionality, hence we separate them into different methods

                            CheckTriangleType(tri);
                        }
                        else if(userInput == "NO")
                        {
                            Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
                            Console.WriteLine("Please enter a number:");
                            string stringNumber1 = Console.ReadLine();  
                            Console.WriteLine("Enter another number:");
                            string stringNumber2 = Console.ReadLine();  
                            Console.WriteLine("Enter a third number:");
                            string stringNumber3 = Console.ReadLine();  
                            tri.Side1 = int.Parse(stringNumber1);  
                            tri.Side2 = int.Parse(stringNumber2);  
                            tri.SetSide3(int.Parse(stringNumber3)); 
                            ConfirmOrEditTriangle(tri);

                            // In any case, keep in mind that you can create a loop by calling on the same method you are declaring within its own definition (eg: calling ConfirmOrEditTriangle() within the ConfirmOrEditTriangle() definition)
                        }
                        else
                        {
                          Console.WriteLine();
                          Console.WriteLine();
                          Console.WriteLine("I'm sorry, I did not get that, let's try again");
                          Console.WriteLine();
                          
                          Main();
                          Console.WriteLine();
                          Console.WriteLine();
                          
                        }
                        
                    }

                    // Like other UI methods, the CheckTriangleType() method is static so that we can call it on the class and not the instance... This is important for the method to work as expected
                    // How this UI method works: we call on the instance method Triangle.CheckType() to determine the type of the triangle

                    static void CheckTriangleType(Triangle tri)
                    {
                        string result = tri.CheckType();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Your result is: " + result + ".");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("What's next?");
                        Console.WriteLine("Would you like to check a new shape (new)?");
                        // PrintAllTriangles();
                        Console.WriteLine("Please enter 'new' to track a new shape. To see all triangles created, enter 'get', to clear all, enter 'clear'");
                        string userResponse = Console.ReadLine().ToUpper(); 
                        
                        if (userResponse == "NEW")
                        {
                          
                          Console.WriteLine();
                          Console.WriteLine();
                            // We are looping back to the start of our program 
                            Main();

                            
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else if(userResponse == "GET")
                        {
                          
                          Console.WriteLine();
                          Console.WriteLine();

                          PrintAllTriangles();

                          
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else if(userResponse == "CLEAR")
                        {
                          
                          Console.WriteLine();
                          Console.WriteLine();

                          ClearAllTriangles();
                          
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else{
                          Console.WriteLine();
                          Console.WriteLine();
                          Console.WriteLine("I'm sorry, I did not get that, let's try again");
                          Main();
                        }
                    }

                    // Writing the functionalities for printing all triangles and to clear all the triangles.

                    // For printing all triangles
                    static void PrintAllTriangles()
                    {
                      
                        Console.WriteLine();
                        Console.WriteLine("Here are all the triangles you have created");
                        Console.WriteLine();
                        List<Triangle> triangleList = Triangle.GetAll();

                        
                        foreach (Triangle triangle in triangleList)
                        {
                            Console.WriteLine($"Triangle with sides {triangle.Side1}, {triangle.Side2}, {triangle.GetSide3()} is a {triangle.CheckType()}");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Lets go Again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                    }

                    // For printing all triangles
                    static void ClearAllTriangles()
                    {
                      Triangle.ClearAll();

                        Console.WriteLine("All Triangles cleared");
                        
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Lets go Again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                    }


                        
                break;
            case "r":
                Console.WriteLine("LTracking Rectangles");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("We'll calculate the area of a rectangle based off of the lengths of 2 sides");

                Console.WriteLine("Please enter a number");
                string newStringNumber1 = Console.ReadLine();

                Console.WriteLine("Enter another number");
                string newStringNumber2 = Console.ReadLine();

                 int rectFirstSide = int.Parse(newStringNumber1);
                int rectSecondSide = int.Parse(newStringNumber2);

                
                Rectangle rect = new Rectangle(rectFirstSide, rectSecondSide);
                ConfirmOrEditRectangle(rect);

                static void ConfirmOrEditRectangle(Rectangle rect)
                {
            
                    Console.WriteLine("Please confirm that you entered in your rectangle sides correctly:");
                    Console.WriteLine($"Side 1 has a length of {rect.Side1}.");
                    Console.WriteLine($"Side 2 has a length of {rect.Side2}.");
                    Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the rectangle sides's sides. ");
                    string userInput = Console.ReadLine().ToLower();  

                    if(userInput == "yes")
                    {
                        CalculateArea(rect);
                    }
                    else if(userInput == "no")
                    {
                        Console.WriteLine("Let's fix your rectangle. Please enter the 3 sides again!");
                        Console.WriteLine("Please enter a number:");
                        string stringNumber1 = Console.ReadLine();  
                        Console.WriteLine("Enter another number:");
                        string stringNumber2 = Console.ReadLine();   
                        rect.Side1 = int.Parse(stringNumber1);  
                        rect.Side2 = int.Parse(stringNumber2);  
                        ConfirmOrEditRectangle(rect);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("I didn't get that, lets try again");
                        Main();
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                     static void CalculateArea(Rectangle rect)
                    {
                        int result = rect.AreaOfRectangle();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("The area of rectangle is: " + result + ".");
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("What's next?");
                        Console.WriteLine("Would you like to check a new triangle (new)?");
                        
                        Console.WriteLine("Please enter 'new' to track a new shape. To see all rectangles created, enter 'get', to clear all, enter 'clear'");
                        string rectUserResponse = Console.ReadLine().ToLower();


                        if (rectUserResponse == "new")
                        {
                          Console.WriteLine();
                          Console.WriteLine();
                            // We are looping back to the start of our program 
                            Main();

                            
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else if(rectUserResponse == "get")
                        {
                          
                          Console.WriteLine();
                          Console.WriteLine();

                          PrintAllRectangles();

                          
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else if(rectUserResponse == "clear")
                        {
                          
                          Console.WriteLine();
                          Console.WriteLine();

                          ClearAllRectangles();
                          
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else{
                          Console.WriteLine();
                          Console.WriteLine();
                          Console.WriteLine("I'm sorry, I did not get that, let's try again");
                          Main();
                        }

                    }

                    static void PrintAllRectangles()
                    {
                         Console.WriteLine();
                        Console.WriteLine("Here are all the rectangles you have created");
                        Console.WriteLine();
                        List<Rectangle> rectangleList = Rectangle.GetAllRectangles();

                        
                        foreach (Rectangle rectangle in rectangleList)
                        {
                            Console.WriteLine($"Rectangle with sides {rectangle.Side1}, {rectangle.Side2} has an area of {rectangle.AreaOfRectangle()}");
                        }
                        // rect.GetAllRectangles();

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Let's go Again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                    }

                    static void ClearAllRectangles()
                    {
                        Rectangle.ClearAllRectangles();
                        Console.WriteLine("All rectangles have been cleared");
                    
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Lets go Again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                    }
                }

                  break;

                case "e":
                  Console.WriteLine();
                  Console.WriteLine();
                  Console.WriteLine("Tracking Ellipses");
                  
                  Console.WriteLine("We'll calculate area of ellipse based off of 2 radius value for the ellipse.");
              
                    // Taking in the inputs from my users

                  Console.WriteLine("Please enter a number");
                  int firstRad = int.Parse(Console.ReadLine());

                  Console.WriteLine("Enter another number");
                  int secondRad = int.Parse(Console.ReadLine());

                  Ellipse newEllipse = new Ellipse(firstRad,secondRad);

                  ConfirmOrEditEllipse(newEllipse);

                  static void ConfirmOrEditEllipse(Ellipse myEllipse)
                  {
                      Console.WriteLine("Please confirm that you entered in your ellipse correctly:");
                      Console.WriteLine($"Radius1 has a length of {myEllipse.RadiusVal1}.");
                      Console.WriteLine($"Radius2 has a length of {myEllipse.RadiusVal2}.");
                      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the ellipse's sides. ");
                      string userInput = Console.ReadLine().ToLower();  

                       if (userInput == "yes")
                        {
                            // We can easily add the code here to check the type of the triangle, but we want to practice a good separation of concern; edit functionality is different form triangle type checking functionality, hence we separate them into different methods

                            CalcEllipseArea(myEllipse);
                        }
                        else if(userInput == "no")
                        {
                            Console.WriteLine("Let's fix your ellipse. Please enter the 2 radius values again!");
                            Console.WriteLine("Please enter a number for radius1:");
                            string stringNumber1 = Console.ReadLine();  
                            Console.WriteLine("Enter another number for radius2:");
                            string stringNumber2 = Console.ReadLine();  
                            myEllipse.RadiusVal1 = int.Parse(stringNumber1);  
                            myEllipse.RadiusVal2 = int.Parse(stringNumber2);  
                            ConfirmOrEditEllipse(myEllipse);

                            // In any case, keep in mind that you can create a loop by calling on the same method you are declaring within its own definition (eg: calling ConfirmOrEditTriangle() within the ConfirmOrEditTriangle() definition)
                        }
                        else
                        {
                          Console.WriteLine();
                          Console.WriteLine();
                          Console.WriteLine("I'm sorry, I did not get that, let's try again");
                          Console.WriteLine();
                          
                          Main();
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        
                    }

                    static void CalcEllipseArea(Ellipse myEllipse)
                    {
                        double result = myEllipse.AreaOfEllipse();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("The area of ellipse is: " + result + ".");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("What's next?");
                        Console.WriteLine("Would you like to check a new shape (new)?");
                        // PrintAllTriangles();
                        Console.WriteLine("Please enter 'new' to track a new shape. To see all triangles created, enter 'get', to clear all, enter 'clear'");
                        string userResponse = Console.ReadLine().ToLower(); 
                        
                         if (userResponse == "new")
                        {
                          
                          Console.WriteLine();
                          Console.WriteLine();
                            // We are looping back to the start of our program 
                            Main();

                            
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else if(userResponse == "get")
                        {
                          
                          Console.WriteLine();
                          Console.WriteLine();

                          PrintAllEllipse();

                          
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else if(userResponse == "clear")
                        {
                          
                          Console.WriteLine();
                          Console.WriteLine();

                          ClearAllMyEllipse();
                          
                          Console.WriteLine();
                          Console.WriteLine();
                        }
                        else{
                          Console.WriteLine();
                          Console.WriteLine();
                          Console.WriteLine("I'm sorry, I didn't get that, let's try again");
                          Main();
                        }
                    }

                    static void PrintAllEllipse()
                    {
                        Console.WriteLine();
                        Console.WriteLine("Here are all the ellipses you have created");
                        Console.WriteLine();
                        List<Ellipse> ellipseList = Ellipse.GetAllEllipses();

                        
                        foreach (Ellipse eachEllipse in ellipseList)
                        {
                            Console.WriteLine($"Ellipse with radius1 value {eachEllipse.RadiusVal1}, and radius2 value {eachEllipse.RadiusVal2} has the area {eachEllipse.AreaOfEllipse()}");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Lets go Again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                    }

                     static void ClearAllMyEllipse()
                    {
                      // the method below is from the Ellipse.cs class
                      Ellipse.ClearAllEllipses();

                        Console.WriteLine("All Ellipses cleared");
                        
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Lets go Again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                    }


              break;

              case "k":
                Console.WriteLine("Good Bye");

              default:
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Didn't get that, lets try again");
                Console.WriteLine();
                Console.WriteLine();
                Main();
                Console.WriteLine();
                Console.WriteLine();
                break;


                  }


                 
        }



                }

          // default:
          //   break;
        }
        


  















