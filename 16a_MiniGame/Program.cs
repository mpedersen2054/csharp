using System;

namespace MiniGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human h = new Human("Guy");
            Wizzard wiz = new Wizzard("Saxmawa");
            wiz.Heal();
            wiz.Fireball(h);
        }
    }
}
