using System;

namespace reverseString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type in a word:");
            string forwardString = Console.ReadLine();
            char[] charArray = forwardString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine(reversedString);

        }
    }
}