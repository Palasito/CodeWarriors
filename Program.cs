using MyFirstConsoleGame_Warriors_.@enum;
using MyFirstConsoleGame_Warriors_.Equipment;

namespace MyFirstConsoleGame_Warriors_
{
    class Program
    {
        static Random rng = new Random();
        static void Main()
        {
            Weapon weapon1 = new Weapon(WeaponType.Pen);
            Armor armor1 = new Armor(ArmorType.Vibranium);

            Weapon weapon2 = new Weapon(WeaponType.FryingPan);
            Armor armor2 = new Armor(ArmorType.Mail);
            Warrior player1 = new Warrior("Palas", "the Great", Faction.Orc, weapon1, armor1);
            Warrior player2 = new Warrior("Foe", "the Shit", Faction.Elf, weapon2, armor2);

            while (player1.IsAlive && player2.IsAlive)
            {
                if (rng.Next(0,10) < 5)
                {
                    player1.Attack(player2);
                    if (player1.Weapon.Speed > player2.Weapon.Speed)
                    {
                        if (rng.Next(0, 10) < 8)
                        {
                            player1.Attack(player2);
                            Console.WriteLine($"{player1.Name} Attacked Again due to faster Weapon");
                        }
                    }
                }
                else
                {
                    player2.Attack(player1);
                    if (player2.Weapon.Speed > player1.Weapon.Speed)
                    {
                        if (rng.Next(0,10) < 8)
                        {
                            player2.Attack(player1);
                            Console.WriteLine($" {player2.Name} Attacked Again");
                        }
                    }
                }
            }
        }
    }

}
