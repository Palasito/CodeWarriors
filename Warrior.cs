using MyFirstConsoleGame_Warriors_.@enum;
using MyFirstConsoleGame_Warriors_.Equipment;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstConsoleGame_Warriors_
{
    class Warrior
    {
        private string title;
        private readonly Faction FACTION;
        private float health;
        private string name;
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return weapon;
            }
        }

        public Armor Armor
        {
            get
            {
                return armor;
            }
        }

        public Warrior(string name, string title, Faction faction, Weapon weapon, Armor armor)
        {
            this.name = name;
            this.FACTION = faction;
            this.title = title;
            this.isAlive = true;
            this.weapon = weapon;
            this.armor = armor;

            switch (faction)
            {
                case Faction.GoodGuy:
                    this.health = 500;
                    break;
                case Faction.BadGuy:
                    this.health = 400;
                    break;
                default:
                    this.health = 0;
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            if (enemy.isAlive)
            {
                float damage = (float)((weapon.Damage - enemy.armor.Deflection) / (enemy.armor.ArmorPoints * 0.5));

                if (damage < 0) 
                { 
                    damage = 0;
                }
                enemy.health -= damage;

                if (enemy.health <= 0)
                {
                    enemy.isAlive = false;
                    Console.WriteLine($"{enemy.name} {enemy.title} is dead! {name} {title} is victorious");
                    Console.WriteLine($"{name} has {health} health remaining!");
                }
                else
                {
                    Console.WriteLine($"{name} attacked {enemy.name}! Inflicted {damage} damage to {enemy.name}!");
                    Console.WriteLine($"Remaining health of {enemy.name} is {enemy.health}");
                }
                Thread.Sleep( 200 );
            }
        }
    }
}
