using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Heroes
{
    enum Slot
    {
        Head,
        Body,
        Legs,
        Weapon
    }

    internal abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Primary PrimaryAttributes;
        public Primary LevelUpGain;
        public Items.WeaponType[] AllowedWeapons { get; set; } 
        public Items.ArmourType[] AllowedArmours { get; set; }
        public Dictionary<Slot, Items.Item> Equipment { get; set; } = new Dictionary<Slot, Items.Item>()
        {
            {Slot.Head, null },
            {Slot.Body, null },
            {Slot.Legs, null },
            {Slot.Weapon, null }
        };

        public Hero(string name, int strength, int dexterity, int intelligence, int incStrength, int incDext, int incIntel, Items.WeaponType[] allowedWeapons, Items.ArmourType[] allowedArmours) {
            Name = name;
            PrimaryAttributes.Strength = strength;
            PrimaryAttributes.Dexterity = dexterity;
            PrimaryAttributes.Intelligence = intelligence;
            LevelUpGain.Strength = incStrength;
            LevelUpGain.Dexterity = incDext;
            LevelUpGain.Intelligence = incIntel;
            AllowedWeapons = allowedWeapons;
            AllowedArmours = allowedArmours;
        }

        public void LevelUp()
        {
            Level++;
            PrimaryAttributes.Strength += LevelUpGain.Strength;
            PrimaryAttributes.Dexterity += LevelUpGain.Dexterity;
            PrimaryAttributes.Intelligence += LevelUpGain.Intelligence;
        }

        public void EquipItem(Items.Item item, Slot slot)
        {
            if (item is Items.Weapon)
            {
                Items.Weapon weapon = (Items.Weapon)item;
                EquipWeapon(weapon, slot);
            }
            else
            {
                Items.Armour armour = (Items.Armour)item;
                EquipArmour(armour, slot);
            }
        }

        private void EquipWeapon(Items.Weapon weapon, Slot slot)
        {
            if (weapon.LevelRequirement > Level || slot != Slot.Weapon || !AllowedWeapons.Contains(weapon.WeaponType))
            {
                throw new Exception("InvalidWeaponException");
            } else
            {
                Equipment[slot] = weapon;
            }
        }

        private void EquipArmour(Items.Armour armour, Slot slot)
        {
            if (armour.LevelRequirement > Level || slot == Slot.Weapon || !AllowedArmours.Contains(armour.ArmourType) {
                throw new Exception("InvalidArmourException");
            } else
            {
                Equipment[slot] = armour;
            }
        }

        public int Damage() 
        {
            //Get DPS from weapon
            int dps = 1;
            if (Equipment[Slot.Weapon] != null)
            {
                Items.Weapon weapon = (Items.Weapon)Equipment[Slot.Weapon];
                dps = weapon.GetDPS();
            }
            else return 1;


            //Get hero attributes
            Primary totalAttributes = PrimaryAttributes;

            //Get armour attributes
            foreach (KeyValuePair<Slot, Items.Item> elem in Equipment)
            {
                if (elem.Value is Items.Armour)
                {
                    Items.Armour armour = (Items.Armour)elem.Value;
                    totalAttributes.Strength += armour.Attributes.Strength;
                    totalAttributes.Dexterity += armour.Attributes.Dexterity;
                    totalAttributes.Intelligence += armour.Attributes.Intelligence;
                }
            }

            //Summerize attributes
            int totalPrimaryAttribute = totalAttributes.Strength + totalAttributes.Dexterity + totalAttributes.Intelligence;

            //Calculate hero damage
            return dps * (1 + totalPrimaryAttribute/100);
        }
    }
}
