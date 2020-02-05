using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UMLDiagram
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get; set; }


        public Wizard(string _name, int _strength, int _intelligence, int _magicalEnergy, int _spellNumber) : base(_name, _strength, _intelligence, _magicalEnergy)
        {
            
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;
            SpellNumber = _spellNumber;
            
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }
    }
}
