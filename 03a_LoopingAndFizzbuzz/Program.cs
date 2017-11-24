using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            // create a loop that prints all values from 1-255
            for (int i = 1; i < 256; i++)
            {
                System.Console.WriteLine(i);
            }

            // create a loop that prints all values from 1-100 that prints fizz if
            // divisible by 3, buzz is divisible by 5, and fizzbuzz if divisible by 3 & 5
            for (int i = 1; i < 100; i++)
            {
                
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz!!! {0}", i);
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz! {0}", i);
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz! {0}", i);
                }
            }

            // generate 10 random values and output either fizz, buzz, or fizzbuzz
            for (int i = 0; i < 10; i++)
            {
                int rand = random.Next(1, 101);
                if (rand % 3 == 0 && rand % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz!!! {0}", rand);
                }
                else if (rand % 3 == 0)
                {
                    System.Console.WriteLine("Fizz! {0}", rand);
                }
                else if (rand % 5 == 0)
                {
                    System.Console.WriteLine("Buzz! {0}", rand);
                }
                else
                {
                    System.Console.WriteLine("{0} is not Fizz, Buzz, or FizzBuzz...", rand);
                }
            }
        }
    }
}
