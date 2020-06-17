using System;

namespace ProceduralBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // The main method is ultimately run by the "dotnet run" commamnd.

            //each "line of code" is a statement ending in a semicolon.

                    
            Console.WriteLine("Enter a number:");

            string userInput = Console.ReadLine();

            //int.parse can convert a string into the int it represents


            int number = int.Parse(userInput);

            number *= 6; // Shorthand for writing number = number * 6

            //The number will be converted back to a strong and combined with the first string
            Console.WriteLine("Six times that is: " + number );

            //Control structures

            // Conditional

            if (number <0 )
            {
                Console.WriteLine("Negative Number");
            }
            else 
            {
                // Loops
                // For loop

                for (; number >= 0 ; number -= 5)
                //(init; test; update until conditional is met )
                {
                    Console.WriteLine(number);
                }
            }

            
        }
    }
}
