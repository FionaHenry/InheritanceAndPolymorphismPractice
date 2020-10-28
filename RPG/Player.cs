using System;

namespace RPG
{
    class Player:Character
    {
        public int money;

        public Player(string name, string type, string size, string language, int hp, int strength, int intelligence, int charisma, int constitution, int wisdom, int armor, int movementSpeed, int money)
            : base(name, type, size, language, hp, strength, intelligence, charisma, constitution, wisdom, armor, movementSpeed)
        {
            this.money = money;
        }
    }
}