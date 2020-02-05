using System;

namespace Lab12UMLDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] characters = new GameCharacter[]
            {
                
                new Warrior("Abe", 50, 1, "Jar of Peanutbutter"),
                new Warrior("Waldo", 1000, 0, "Bed"),
                new Wizard("Farhat the Grey", 1, 25, 11, 3),
                new Wizard("Hassan the Flu", 11, 22, 18, 5),
                new Wizard("Abyss", 1, 1, 1, 1)
            };

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].Play();

            }
        }
    }
}
