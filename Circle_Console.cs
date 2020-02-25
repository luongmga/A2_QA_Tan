using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lack of header comments
//creators, date time, purpose
//revision history
//the entire file has many blank lines
namespace RGBAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //lack of class Circle
            Circle circle = new Circle();

            int radius = 0;
            int menuOption = 0; //a string is better

            radius = GetRadiusFromUserInput(radius);
            //Meanningless nested do-while loops
            //1 do-while loop, switch case on string menuOption is better
            //default case of switch state will take care of non-conforming input
            do
            {
                do
                {
                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();
                    
                    try
                    {
                        menuOption = int.Parse(Console.ReadLine()); //should just take user input as string
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Wrong option, please select from the menu:");
                        Console.WriteLine();
                    }
                    //unnesessary blank line

                } while (menuOption == 0 || menuOption < 0 || menuOption > 5); //shorter version: (menuOption <=0 || menuOption >5)

                switch (menuOption) //switch statement should be inside the first do-while loop
                {   //better case "1" , "2", "3", "4", "5" and default
                    case 1:
                        radius = circle.GetRadius(); //undeclared function GetRadius()
                        Console.WriteLine("the radius value is now: " + radius);  //better use expression "the radius value is now: {0}",radius);
                        Console.WriteLine();
                        break;
                    case 2: //unused blank line
                        
                        radius = GetRadiusFromUserInput(radius);
                        circle.SetRadius(radius);
                        Console.WriteLine("the radius value is now: " + radius);//better use expression "the radius value is now: {0}",radius);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("The circumference of the circle is: " + Math.Round(circle.GetCircumference(), 2)); //unknown GetCircumference method
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("The Area of the circle is: " + Math.Round(circle.GetArea(), 2));//unknown GetArea method
                        Console.WriteLine();
                        break;
                    case 5:
                        Environment.Exit(0); //Process complete successfully
                        break;
                    default: //this default case is the catcher of all invalid inputs, please use it better
                        break;
                }

            } while (menuOption > 0 || menuOption < 5);
        }

        private static int GetRadiusFromUserInput(int radius) //this method will take negative input
        {
            do
            {
                Console.WriteLine("Please enter radius value: ");
                Console.WriteLine();

                try
                {
                    radius = int.Parse(Console.ReadLine()); //this parse takes negative
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Not the correct format, please insert a int greater than zero!");
                    Console.WriteLine();
                }

            } while (radius == 0); //better condition is (radius > 0)
            return radius;
        }


    }

}
