using MyFirstConsoleGame_Warriors_.@enum;

namespace MyFirstConsoleGame_Warriors_
{
    class Armor
    {
        private float armorPoints;
        private float deflection;
        private ArmorType type;

        public float ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public float Deflection
        {
            get
            {
                return deflection;
            }
        }

        public ArmorType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public Armor(ArmorType type)
        {
            this.type = type;

            switch (type)
            {
                case ArmorType.Cloth: 
                    this.armorPoints = 10;
                    this.deflection = 50;
                    break;
                case ArmorType.Leather: 
                    this.armorPoints = 20;
                    this.deflection = 40;
                    break;
                case ArmorType.Mail: 
                    this.armorPoints = 30;
                    this.deflection = 30;
                    break;
                case ArmorType.Plate: 
                    this.armorPoints = 40;
                    this.deflection = 20;
                    break;
                case ArmorType.Vibranium: 
                    this.armorPoints = 50;
                    this.deflection = 10;
                    break;
                case ArmorType.Kasmir:
                    this.armorPoints = 18;
                    this.deflection = 1;
                    break;
                case ArmorType.Microfiber:
                    this.armorPoints = 28;
                    this.deflection = 19;
                    break;
                case ArmorType.Mohair:
                    this.armorPoints = 38;
                    this.deflection = 9;
                    break;
                case ArmorType.Silk:
                    this.armorPoints = 8;
                    this.deflection = 34;
                    break;
            }
        }
    }
}