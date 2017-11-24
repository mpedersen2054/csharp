using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Dictionaries are similar to Lists and also require
            // including using System.Collections.Generic;
            // Whereas Lists are accessed by a predefined idx, Dictionaries
            // are accessed by a specified key/value pair, both must be specified at init
            Dictionary<string,string> car = new Dictionary<string,string>();
            car.Add("Make", "Chevy");
            car.Add("Model", "HHR");
            car.Add("Year", "2010");
            System.Console.WriteLine($"I am a {car["Make"]} {car["Model"]}");

            // accessing k/v in Dictionaries is similar to arrs or lists, but with 1 different,
            // we must use KeyValuePair because we want k/v instead of idx or a value.
            foreach (KeyValuePair<string,string> attr in car)
            {
                System.Console.WriteLine($"{attr.Key} - {attr.Value}");
            }

            // an easier way to do this is with using TYPE INTERFACING. type interfacing looks like this:
            foreach (var attr in car)
            {
                System.Console.WriteLine($"{attr.Key} - {attr.Value}");
            }
            // type interfacing should be used sparingly
        }
    }
}
