using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UMLDiagram
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(string _name, int _strength, int _intelligence, int _magicalEnergy)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
