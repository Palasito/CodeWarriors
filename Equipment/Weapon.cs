using MyFirstConsoleGame_Warriors_.@enum;

namespace MyFirstConsoleGame_Warriors_.Equipment
{
    class Weapon
    {
        private int damage;
        private int critDamage;
        private int speed;
        private WeaponType type;

        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public int CritDamage
        {
            get
            {
                return critDamage;
            }
        }

        public Weapon(WeaponType type)
        {
            this.type = type;
            switch (type)
            {
                case WeaponType.Axe:
                    damage = 24;
                    critDamage = 30;
                    speed = 10;
                    break;
                case WeaponType.Sword:
                    damage = 15;
                    critDamage = 23;
                    speed = 50;
                    break;
                case WeaponType.Pin:
                    damage = 6;
                    critDamage = 10;
                    speed = 100;
                    break;
                case WeaponType.Pen:
                    damage = 40;
                    critDamage = 60;
                    speed = 60;
                    break;
                case WeaponType.FryingPan:
                    damage = 75;
                    critDamage = 100;
                    speed = 1;
                    break;

            }
        }
    }
}
