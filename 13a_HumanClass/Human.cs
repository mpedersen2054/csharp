
namespace HumanApp
{
    public class Human
    {
        public string name;
        public int strength = 3;
        public int intellegence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Human(string givenName)
        {
            name = givenName;
        }
        // (overload) for setting all fields
        public Human(string givenName, int givenStr, int givenIntel, int givenDex, int givenHp)
        {
            name = givenName;
            strength = givenStr;
            intellegence = givenIntel;
            dexterity = givenDex;
            health = givenHp;
        }

        public void Attack(Human target)
        {
            int damage = 5 * strength;
            System.Console.WriteLine(damage);
            target.health = target.health - damage;
            System.Console.WriteLine($"{target.name} now has {target.health} health.");
        }
    }
}