using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Classes define what objects we can build, how we can interact with them,
            // and how they themselves interact with our program. A simple way to look at
            // classes is as a blueprint of functions and properties that we want as an
            // instance of this class, AKA an Object, to hold. 

            // look in Vehicle.cs
            Vehicle car = new Vehicle(4);
            Vehicle bike = new Vehicle(1);
            System.Console.WriteLine(car.numPassengers);

            System.Console.WriteLine(car.distance);
            System.Console.WriteLine(bike.distance);
            car.Move(2.3);
            bike.Move(0.8);
            System.Console.WriteLine(car.distance);
            System.Console.WriteLine(bike.distance);
            
        }
    }
}
