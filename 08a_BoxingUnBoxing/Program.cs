using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // In C# every variable needs an associated type at compile time due to it using static typing.
            // but what if we wanted to a collections with varying types of data? We do this with a trick
            // called Boxing/Unboxing. We cast everything to 'object'. 
            // So if you construct a list of type 'object' you will be able to hold varying types in one collection.
            // we have to keep in mind that when working with any data in a collection of this type we have to be 
            // sure to cast it back to its original type when retrieving it, or else it will be seen as just 'object'

            // we want to make sure the object is the data-type we are trying to use, so we use the 'is' keyword
            object boxedData = "This is crearly a string";
            if (boxedData is string)
            {
                System.Console.WriteLine("We have a string value in this box!");
            }
            else
            {
                System.Console.WriteLine("The boxed item was not a string...");
            }

            // Unlike type conversion casting, unboxing casting doesn't create a new memory space, 
            // it simply changes how the system references the object. When unboxing we also
            // have the ability to use another form of casting, safe explicit casting.

            // Unlike explicit casting, if a safe cast fails it will simply return
            // a null value rather than throwing an exception. 
            object boxedData2 = "a cool string";
            string coolString = boxedData2 as string;
            System.Console.WriteLine(coolString);


            // Create an empty List of type object
            List<object> items = new List<object>();
            // Add the following values to the list: 7, 28, -1, true, "chair"
            items.Add(7);
            items.Add(28);
            items.Add(-1);
            items.Add(true);
            items.Add("chair");
            // Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach (object item in items)
            {
                System.Console.WriteLine(item);
            }
            // Add all values that are Int type together and output the sum
            int total = 0;
            foreach (object item in items)
            {
                if (item is int)
                {
                    System.Console.WriteLine($"{item} is an int!");
                    int num = (int)item;
                    total += num;
                }
            }
            System.Console.WriteLine($"The total of all the ints is: {total}");
        }
    }
}
