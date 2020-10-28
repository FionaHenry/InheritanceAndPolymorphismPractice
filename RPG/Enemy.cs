using System;

namespace RPG
{
    class Enemy:Character
    {
        // This could be done differently but for now an enemy can only be holding one item which can be looted
        public string loot;

        public Enemy(string name, string type, string size, string language, int hp, int strength, int intelligence, int charisma, int constitution, int wisdom, int armor, int movementSpeed, string loot)
            : base(name, type, size, language, hp, strength, intelligence, charisma, constitution, wisdom, armor, movementSpeed)
        {
            this.loot = loot;
        }
    }
}