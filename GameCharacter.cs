using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UMLDiagram
{
    class GameCharacter
    {
        //fields
        private string name;
        private int strength;
        private int intelligence;

        //properties
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        //constructor 
        //default since im not creating an object.

        

        public virtual void Play()
        {
            Console.WriteLine($"Named: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
        }
    }
}
