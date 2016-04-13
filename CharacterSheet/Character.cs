using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterSheet
{
    public class Character
    {
        public string name, charClass, dexterity, strength, health, perk;

        public Character(string _name, string _charClass, string _dexterity, string _strength, string _health, string _perk)
        {
            name = _name;
            charClass = _charClass;
            dexterity = _dexterity;
            strength = _strength;
            health = _health;
            perk = _perk;
        }
    }
}
