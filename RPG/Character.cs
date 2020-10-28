using System;

namespace RPG
{
    class Character
    {
        public string name;
        public string type;
        public string size;
        public string language;
        public int hp;
        public int strength;
        public int intelligence;
        public int charisma;
        public int constitution;
        public int wisdom;
        public int armor;
        public int movementSpeed;
        public Character(string name, string type, string size, string language, int hp, int strength, int intelligence, int charisma, int constitution, int wisdom, int armor, int movementSpeed)
        {
            this.name = name;
            this.type = type;
            this.size = size;
            this.language = language;
            this.hp = hp;
            this.strength = strength;
            this.intelligence = intelligence;
            this.charisma = charisma;
            this.constitution = constitution;
            this.wisdom = wisdom;
            this.armor = armor;
            this.movementSpeed = movementSpeed;
        }

        public void DisplayStats()
        {
            Console.WriteLine(name);
            Console.WriteLine(type);
            Console.WriteLine(size);
            Console.WriteLine(language);
            Console.WriteLine(hp);
            Console.WriteLine(strength);
            Console.WriteLine(intelligence);
            Console.WriteLine(charisma);
            Console.WriteLine(constitution);
            Console.WriteLine(wisdom);
            Console.WriteLine(armor);
            Console.WriteLine(movementSpeed);
        }
    }
}