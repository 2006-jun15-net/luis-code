using System;
using System.Collections.Generic;


namespace list_tutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            // WorkingWithStrings();
            var fibonacciNumbers = new List<int> { 1, 1 };
            while (fibonacciNumbers.Count < 20)
            {
                
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var number in fibonacciNumbers)
                Console.WriteLine(number);
        }

        static void WorkingWithStrings()
        {
            var names = new List<string> { "Luis", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
