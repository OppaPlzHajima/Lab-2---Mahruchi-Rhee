using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal l;
            decimal w;
            decimal h;
            string y = "Y";
            string x="Y";


            while (x== "Y" || x == "y")
            {

                Console.WriteLine("WELCOME TO GRAND CIRCUS' ROOM DETAIL GENERATOR");

                Console.WriteLine("Please enter a length (inches)");
                l = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please Enter a width (inches)");
                w = Convert.ToDecimal(Console.ReadLine());

                decimal a = l * w;
                decimal p = 2 * l + 2 * w;

                Console.WriteLine("Your area is " + a + " in^2");
                Console.WriteLine("Your perimeter is " + p + " in");

                Console.WriteLine(" Would you like to calculate volume? (Y/N)");
                    y = Console.ReadLine();

                if (y == "N" || y == "n") 

                {
                Console.WriteLine("I see how it is - fine");

                }

                else if (y == "Y" || y == "y")
                {
                    Console.WriteLine(" Please Enter your height (in).");
                      h = Convert.ToDecimal(Console.ReadLine());

                    decimal volume = a * h;

                        Console.WriteLine(" Your volume is " + volume + " inch^3");

                }
                Console.WriteLine("Would you like to continue? (Y / N)");

                x = Console.ReadLine();


                if (x == "N" || x == "n")

                {
                    Console.WriteLine("Thank you for using Grand Circus' Room Detail Generator...............Good bye");

                }
             }
        }
                

                

                    
  

                
            }
                


            
        }
    


