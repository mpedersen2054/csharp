using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // in C# we cannot inherit from multiple classes. We can use something
            // called interface, which basically makes the Class using it HAVE to
            // have specific attrs/methods defined in the interface

            CanRun obj1 = new Bird();
            CanRun obj2 = new Dodo();

            // If we intend to build a class only for the purpose of inheriting 
            // from it and never intend to instantiate an object of it, that class
            // is better off being created as an abstract class. 
        }

        public interface CanRun
        {
            int Run();
        }
        // applying the CanRun interface
        public class Bird : CanRun
        {
            public int Run()
            {
                System.Console.WriteLine("I am running");
                return 5;
            }
        }
        // inheriting from Bird and applying the CanRun interface
        public class Dodo : Bird, CanRun
        {
            public int Run()
            {
                System.Console.WriteLine("running in the wrong direction!");
                return -10;
            }
        }

        // abstract class
        public abstract class Animal
        {
            public string[] chars {get; set;}
            
            //No reason making the constructor public since it can not be
            //Invoked other than from a class inheriting from this class
            protected Animal()
            {
                chars = {
                    "Multicellular",
                    "Eukaryotic Cell Structure",
                    "Specialized Tissues",
                    "Heterotrophs",
                    "Nervous System"
                }
            }
        }
    }
}
