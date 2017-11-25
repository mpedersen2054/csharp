using System;

namespace ConsoleApplication
{
    public class Program
    {
        // passing in params
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}, how are you doing today?", name);
        }
        // default params
        public static void SayHello2(string name = "buddy")
        {
            Console.WriteLine("Hey " + name);
        }
        // return a string
        public static string SayHello3(string name = "buddy")
        {
            return $"Hey {name}";
        }
        public static void Main(string[] args)
        {
            // accessibilty levels:
            // public: can be accessed anywhere in the program that can see the file
            // private: can only be accessed within the same scope as the definition

            // non-static method has to be called on an instance of an object, whereas
            // static can be free standing

            // void is used when the function has NO return value. If there is a return value
            // you must specify what is expected to be returned

            SayHello("Yoda");
            SayHello2();
            string name = SayHello3("Matt");
            System.Console.WriteLine(name);
        }
    }
}
