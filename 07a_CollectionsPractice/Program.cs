using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // arrays
            // Create an array to hold integer values 0 through 9
            int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] arr2 = { "Tim", "Martin", "Nikki", "Sara" };
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] arr3 = { true, false, true, false, true, false, true, false, true, false };

            // multi-demensional arrays
            // With the values 1-10, use code to generate a multiplication table like the one below.
            // method 1
            int[,] mTable = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mTable[i,j] = (j + 1) * (i + 1);
                }
            }
            foreach (int row in mTable)
            {
                // System.Console.WriteLine(row);
            }
            // method 2
            int[][] mTable2 = new int[10][];
            for (int i = 0; i < 10; i++)
            {
                int[] mTable2Row = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    mTable2Row[j] = (j + 1) * (i + 1);
                }
                mTable2[i] = mTable2Row;
            }
            for (int i = 0; i < mTable2.Length; i++)
            {
                System.Console.WriteLine($"Row for {i + 1}");
                for (int j = 0; j < mTable2[i].Length; j++)
                {
                    System.Console.WriteLine(mTable2[i][j]);
                }
                System.Console.WriteLine("===========");
            }   

            // lists
            // Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> ic = new List<string>();
            ic.Add("Vanilla");
            ic.Add("Chocolate");
            ic.Add("Strawberry");
            ic.Add("Swirl");
            ic.Add("Oreo");
            // Output the length of this list after building it
            System.Console.WriteLine(ic.Count);
            // Output the third flavor in the list, then remove this value.
            System.Console.WriteLine(ic[2]);
            ic.RemoveAt(2);
            // Output the new length of the list (Note it should just be one less~)
            System.Console.WriteLine(ic.Count);

            // dictionaries
            // Create a Dictionary that will store both string keys as well as string values
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value to random icecream
            Dictionary<string,string> people = new Dictionary<string,string>();
            Random rando = new Random();
            foreach (string person in arr2)
            {
                people.Add(person, ic[rando.Next(ic.Count)]);
            }
            // Loop through the Dictionary and print out each user's name and their associated ice cream flavor.
            foreach (var person in people)
            {
                System.Console.WriteLine($"My name is {person.Key} and my fav icecream is {person.Value}");
            }
        }
    }
}
