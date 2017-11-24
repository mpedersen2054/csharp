using System;
using System.Collections.Generic; // allows us to use lists

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Lists in C# are most similar to arrays in JS. They are an implementation
            // of linked lists. Once you create a list you can freely add/remove items
            // from the list, and access values by idx independant of a declared size.
            // to use lists, we need to include 'using System.Collections.Generic;'
            List<string> cars = new List<string>();
            cars.Add("Chevy");
            cars.Add("Ford");
            cars.Add("Toyota");
            cars.Add("Mercedes");
            System.Console.WriteLine("I should be Ford: {0}", cars[1]);

            // list of more List methods: https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx

            // to remove items from a List
            cars.Remove("Toyota");
            cars.RemoveAt(0);
            cars.Add("Lambo");
            cars.Add("Tesla");

            // iterating through a list is similar to an array
            foreach (string car in cars)
            {
                System.Console.WriteLine($"I am a {car}");
            }
        }
    }
}
