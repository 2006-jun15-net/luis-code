using System;

namespace interactiveStaircaseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's build some stairs!");
            Console.WriteLine("How many steps high should it be?");
            int staircaseSize = int.Parse(Console.ReadLine());

            int[] numberOfStairs = new int[staircaseSize];
            String stairs = "";
            String space = new String(' ', numberOfStairs.Length);
            for (int i = 0; i <= numberOfStairs.Length; i++ ) 
            {
                if (space.Length > 0)
                {
                    space = space.Substring(1);
                    stairs = (stairs + "#");
                    Console.WriteLine(space + stairs);
                } 
                
            } 
        }
    }
}
