using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UMLDiagram
{
    class Warrior : GameCharacter
    {
        private string weaponType;

        public string WeaponType { get; set; }

        //constructor
        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            WeaponType = _weaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon type: {WeaponType}");
        }
    }
}
