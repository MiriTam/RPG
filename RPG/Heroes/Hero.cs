using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Heroes
{
    internal abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Primary PrimaryAttributes;
        public Primary TotalAttributes;
        public Primary LevelUpGain;

        public Hero(string name, int strength, int dexterity, int intelligence, int incStrength, int incDext, int incIntel) {
            Name = name;
            PrimaryAttributes.Strength = strength;
            PrimaryAttributes.Dexterity = dexterity;
            PrimaryAttributes.Intelligence = intelligence;
            LevelUpGain.Strength = incStrength;
            LevelUpGain.Dexterity = incDext;
            LevelUpGain.Intelligence = incIntel;
        }

        public void Damage() { }

        public void LevelUp()
        {
            Level++;
            PrimaryAttributes.Strength += LevelUpGain.Strength;
            PrimaryAttributes.Dexterity += LevelUpGain.Dexterity;
            PrimaryAttributes.Intelligence += LevelUpGain.Intelligence;
        }
    }
}
