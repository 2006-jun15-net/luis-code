using System;

namespace staircaseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfStairs = new int[8];
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
