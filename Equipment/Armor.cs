using MyFirstConsoleGame_Warriors_.@enum;

namespace MyFirstConsoleGame_Warriors_
{
    class Armor
    {
        private int armorPoints;
        private int deflection;
        private ArmorType type;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public int Deflection
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
            }
        }
    }
}