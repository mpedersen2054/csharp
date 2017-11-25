using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static Random random = new Random();
        // place 10 random ints between 5-25 in an array, print min/max/sum
        public static void randomNumbers()
        {
            int[] arr = new int[10];
            // create array
            for (int i = 0; i < 10; i++)
            {
                arr[i] = random.Next(5, 26);
            }
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            // get min/max/sum
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine($"Min: {min}");
            System.Console.WriteLine($"Max: {max}");
            System.Console.WriteLine($"Sum: {sum}");
        }
        // function that flips a coin
        public static string tossCoin()
        {
            int result = random.Next(2);
            string retStr;
            if (result == 0)
            {
                retStr = "Heads";
            }
            else
            {
                retStr = "Tails";
            }
            return retStr;
        }
        // toss multiple coins
        public static double tossMultiple(int times)
        {
            int hwins = 0;
            int twins = 0;
            for (var i = 0; i < times; i++)
            {
                string toss = tossCoin();
                if (toss == "Heads")
                {
                    hwins++;
                }
                else
                {
                    twins++;
                }
            }
            return (double)(hwins / twins);
        }
        public static void Main(string[] args)
        {
            // randomNumbers();
            System.Console.WriteLine(tossMultiple(5));
        }
    }
}
