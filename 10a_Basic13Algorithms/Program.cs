using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static string printEachValue(int[] arr)
        {
            string retVal = "[";
            foreach (int val in arr)
            {
                // if its the last item in array
                if (val == arr[arr.Length - 1])
                {
                    retVal += $"{val.ToString()}";    
                }
                else
                {
                    retVal += $"{val.ToString()}, ";
                }
            }
            retVal += " ]";
            return retVal;
        }
        // Write a program (sets of instructions) that would print all the numbers from 1 to 255
        public static void printNumbers()
        {
            for (int i = 1; i < 256; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        // print all odd #s 1-255
        public static void printOdds()
        {
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        // print all #s 1-255 along with the sum
        public static void printNumsWithSum()
        {
            int sum = 0;
            for (int i = 1; i < 256; i++)
            {
                sum += i;
                System.Console.WriteLine($"Sum: {sum} - Num: {i}");
            }
        }
        // print each val of arr [1,3,5,7,9,13]
        public static void printArrVals(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine($"{arr[i]}");
            }
        }
        // find the max val of arr
        public static void findMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine($"Max: {max}");
        }
        // find the average of arr
        public static void findAvg(int[] arr)
        {
            // need floats if average isnt whole #
            float total = 0;
            float avg;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
                System.Console.WriteLine(total);
            }
            avg = (float)(total / arr.Length);
            System.Console.WriteLine($"Average: {avg}");
        }
        // creates an array of all the odd #s 1-255
        public static void arrayOfOdds()
        {
            int[] odds = new int[256 / 2];
            int oddsIdx = 0;
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 != 0)
                {
                    odds[oddsIdx] = i;
                    oddsIdx++;
                }
            }
            System.Console.WriteLine(printEachValue(odds));
        }
        // takes a value and returns all vals that are > val
        public static void findAllGtNums(int[] arr, int num)
        {
            int gt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > num)
                {
                    gt++;
                }
            }
            System.Console.WriteLine($"There are {gt} items greater than {num}");
        }
        // squares all #s in array
        public static void squareNums(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            System.Console.WriteLine(printEachValue(arr));
        }
        // replace all negative nums in array with 0
        public static void replaceNegs(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            System.Console.WriteLine(printEachValue(arr));
        }
        // return the mix, max & avg
        public static void findMinMaxAvg(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            float total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
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
            System.Console.WriteLine($"Average: {total / arr.Length}");
        }
        // shift all items in array by 1 and place 0 at the end
        public static void shiftVals(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;
            System.Console.WriteLine(printEachValue(arr));
        }
        // replace any #s in arr that are negative with "Negative"
        public static void replaceNegsWString(object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] < 0)
                {
                    arr[i] = "Negative";
                }
            }
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            int[] exampleArr = { 1, 3, -2, 5, 7, -20, -4, 9, 13 };
            object[] exampleArr2 = { 1, 3, -2, 5, 7, -20, -4, 9, 13 }; // for replacing #s with "Negative"
            // printNumbers();
            // printOdds();
            // printNumsWithSum();
            // printArrVals(exampleArr);
            // findMax(exampleArr);
            // findAvg(exampleArr);
            // arrayOfOdds();
            // findAllGtNums(exampleArr, 5);
            // squareNums(exampleArr);
            // replaceNegs(exampleArr);
            // findMinMaxAvg(exampleArr);
            // shiftVals(exampleArr);
            replaceNegsWString(exampleArr2);
        }
    }
}
