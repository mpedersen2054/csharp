using System;
using System.Collections.Generic;

namespace MiniGame
{
    public class Human
    {
        public string name;
        public int health;
        public int strength;
        public int intel;
        public int dexterity;

        public Human(string givenName)
        {
            name = givenName;
            health = 100;
            strength = 3;
            intel = 3;
            dexterity = 3;
        }
        public Human(string givenName, int hp, int str, int inte, int dex)
        {
            name = givenName;
            health = hp;
            strength = str;
            intel = inte;
            dexterity = dex;
        }

        public void Attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                System.Console.WriteLine("Failed attack...");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }

        public void Stats()
        {
            System.Console.WriteLine($"name: {name}");
            System.Console.WriteLine($"health: {health}");
            System.Console.WriteLine($"strength: {strength}");
            System.Console.WriteLine($"intellegence: {intel}");
            System.Console.WriteLine($"dexterity: {dexterity}");
        }
    }
}