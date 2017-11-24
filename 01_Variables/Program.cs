using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte byteNum = 2;
            int number = 100;
            float price = 29.95f;
            char character = 'A';
            string person = "Matt Pedersen";
            int age = 25;
            bool isWorking = true;
            
            var another1 = "hello world!";
            var another2 = 23;
            
            System.Console.WriteLine(byteNum);
            System.Console.WriteLine(number);
            System.Console.WriteLine(price);
            System.Console.WriteLine(character);
            System.Console.WriteLine(person);
            System.Console.WriteLine(isWorking);

            System.Console.WriteLine(another1);
            System.Console.WriteLine(another2);

            System.Console.WriteLine("My name is {0} and I am {1}", person, age);
        }
    }
}
