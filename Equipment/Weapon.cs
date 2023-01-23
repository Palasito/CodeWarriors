using MyFirstConsoleGame_Warriors_.@enum;

namespace MyFirstConsoleGame_Warriors_.Equipment
{
    class Weapon
    {
        private float damage;
        private int critDamage;
        private int speed;
        private WeaponType type;

        public float Damage
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

        public int Speed
        {
            get
            {
                return speed;
            }
        }

        public Weapon(WeaponType type)
        {
            this.type = type;
            switch (type)
            {
                case WeaponType.Axe:
                    damage = 124;
                    critDamage = 30;
                    speed = 10;
                    break;
                case WeaponType.Sword:
                    damage = 115;
                    critDamage = 23;
                    speed = 50;
                    break;
                case WeaponType.Pin:
                    damage = 106;
                    critDamage = 10;
                    speed = 100;
                    break;
                case WeaponType.Pen:
                    damage = 140;
                    critDamage = 60;
                    speed = 60;
                    break;
                case WeaponType.FryingPan:
                    damage = 175;
                    critDamage = 100;
                    speed = 1;
                    break;

            }
        }
    }
}
