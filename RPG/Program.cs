using System;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();

            Character c1 = new Player("bob", "badass", "tiny", "HONKING", 40, 10, 93, 7, 12, 28, 32, 4, 30);

            c1.DisplayStats();
        }
    }
}
