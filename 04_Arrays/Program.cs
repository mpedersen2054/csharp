using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Arrays in C# must have an exact length that is specified
            // when the array is created, and this length cannot be changed.
            int[] arr1 = new int[5];
            int[] arr2 = { 1, 2, 3, 4, 5 };

            // you can access items in an array using bracket notation
            System.Console.WriteLine(arr2[0]);
            System.Console.WriteLine(arr2[1]);
            
            // you can redefine a value at a particular idx after its been set
            arr2[0] = 8;
            System.Console.WriteLine(arr2[0]);

            // iterating through an array you can use either a for loop or a foreach loop
            string[] cars = new string[4] { "Mazda", "Toyota", "Ford", "Chevy" };
            for (int i = 0; i < cars.Length; i++)
            {
                System.Console.WriteLine("I am a {0}", cars[i]);
            }
            foreach(string car in cars)
            {
                System.Console.WriteLine("I am a {0}", car);
            }

            // for multidemensional arrays you need to specify not only the the number
            // of inner arrays, but also the size of each inner array
            int[,,] arr3d = new int[2, 3, 4]
            {
                { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } },
                { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } }
            };
            System.Console.WriteLine(arr3d[0,0,1]); // should be 2
            System.Console.WriteLine(arr3d[1, 2, 3]); // should be 24
            // one constraint multi-demensional arrays pose is that they are perfectly
            // rectangular, with all inner arrays having the same length

            // if we want to vary the lengths, we can use a 'jagged array'
            int[][] jarr = new int[][]
            {
                new int[] { 3, 5, 2, 1 },
                new int[] { 1, 2 },
                new int[] { 10, 1, 5, 4, 7, 8 }
            };
            // accessing jagged arrays
            foreach (int[] arr in jarr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    System.Console.WriteLine(arr[i]);
                }
            }
            // access indv
            System.Console.WriteLine("I should be 5: {0}", jarr[2][2]);
        }
    }
}
