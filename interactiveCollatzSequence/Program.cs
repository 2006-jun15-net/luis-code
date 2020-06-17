using System;

namespace interactiveCollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number!");
            int collatzNumber = int.Parse(Console.ReadLine());

            while(collatzNumber > 1)
            {
                if(collatzNumber % 2 == 0)
                {
                    collatzNumber /= 2;
                    Console.WriteLine(collatzNumber);
                }
                else 
                {
                    collatzNumber = collatzNumber * 3 + 1;
                    Console.WriteLine(collatzNumber);
                }
            }    

        }
    }
}
