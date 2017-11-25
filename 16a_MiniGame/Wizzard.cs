using System;
using System.Collections.Generic;

namespace MiniGame
{
    public class Wizzard : Human
    {
        public Random random = new Random();
        public Wizzard(string n) : base(n)
        {
            health = 50;
            intel = 25;
        }

        public void Heal()
        {
            int oldHp = health;
            System.Console.WriteLine($"{name} is healing...");
            health += 10 * intel;
            System.Console.WriteLine($"{name} went from {oldHp} to {health}");
        }

        public void Fireball(object obj)
        {
            Human enemy = obj as Human;
            int damage = random.Next(20, 51);
            enemy.health -= damage;
            System.Console.WriteLine($"{name} did {damage} to {enemy.name}");
        }
    }
}