using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // implicit
            byte b1 = 1;
            int i1 = b1;
            System.Console.WriteLine(i1);

            // explicit
            int i2 = 1;
            byte b2 = (byte)i2;
            System.Console.WriteLine(b2);

            // non-compatible types
            string s1 = "25";
            int num = Convert.ToInt32(s1);
            System.Console.WriteLine(num);

            // use try block to handle exception
            // prevents the application for crashing
            try
            {
                string number = "254";
                byte b = Convert.ToByte(number);
                System.Console.WriteLine("The Number is: {0}", b);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The Number could not be converted to a byte...");
                throw;
            }

            string interpol = $"The answer to 7 + 5 is {7 + 5}";
            System.Console.WriteLine(interpol);
        }
    }
}
