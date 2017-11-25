using System;

namespace HumanApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human p1 = new Human("Matt");
            Human p2 = new Human("Dan");

            p1.Attack(p2);
        }
    }
}
