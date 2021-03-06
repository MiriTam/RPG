using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Heroes
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
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

        /// <summary>
        /// Method used to level up a hero. Increases the hero's attributes based on 
        /// her LevelUpGain attributes.
        /// </summary>
        public void LevelUp()
        {
            Level++;
            PrimaryAttributes.Strength += LevelUpGain.Strength;
            PrimaryAttributes.Dexterity += LevelUpGain.Dexterity;
            PrimaryAttributes.Intelligence += LevelUpGain.Intelligence;
        }

        /// <summary>
        /// Method used to add an item to the hero's equipment.
        /// </summary>
        /// <param name="item">The item to added to the hero's equipment.</param>
        /// <param name="slot">The equipment slot to put the equipment into.</param>
        public string EquipItem(Items.Item item, Slot slot)
        {
            if (item is Items.Weapon)
            {
                Items.Weapon weapon = (Items.Weapon)item;
                return EquipWeapon(weapon, slot);
            }
            else
            {
                Items.Armour armour = (Items.Armour)item;
                return EquipArmour(armour, slot);
            }
        }

        /// <summary>
        /// Method used to add a weapon to the hero's equipment. Throws an InvalidWeaponException if the weapon is of too 
        /// high a level, the selected equipment slot is not for weapons, or the hero is not allowed to use that type
        /// of weapon.
        /// </summary>
        /// <param name="weapon">The weapon to be equiped.</param>
        /// <param name="slot">The slot in which to equip the weapon.</param>
        /// <exception cref="Exception">InvalidWeaponException</exception>
        private string EquipWeapon(Items.Weapon weapon, Slot slot)
        {
            if (weapon.LevelRequirement > Level)
            {
                throw new InvalidWeaponException("Level too high!");
            } 
            else if (slot != Slot.Weapon)
            {
                throw new InvalidWeaponException("Not a weapon slot!");
            } 
            else if (!AllowedWeapons.Contains(weapon.WeaponType))
            {
                throw new InvalidWeaponException("Wrong weapon type!");
            } 
            else
            {
                Equipment[slot] = weapon;
            }
            return "New weapon equiped!";
        }

        /// <summary>
        /// Method used to add armour to the hero's equipment. Throws an InvalidArmourException if the armour is of too
        /// high a level, the selected equipment slot is not for armour, or the hero is not allowed to use that type
        /// of armour.
        /// </summary>
        /// <param name="armour">The armour to be equiped.</param>
        /// <param name="slot">The slot in which to equip the armour.</param>
        /// <exception cref="Exception">InvalidArmourException</exception>
        private string EquipArmour(Items.Armour armour, Slot slot)
        {
            if (armour.LevelRequirement > Level) 
            { 
                throw new InvalidArmourException("Level too high!");
            } 
            else if (slot == Slot.Weapon)
            {
                throw new InvalidArmourException("Not an armour slot!");
            }
            else if (!AllowedArmours.Contains(armour.ArmourType))
            {
                throw new InvalidArmourException("Wrong armour type!");
            }
            else
            {
                Equipment[slot] = armour;
            }
            return "New armour equiped!";
        }

        /// <summary>
        /// Method calculates and returns the total damage dealt by the hero based on her attributes and equipment. 
        /// </summary>
        /// <returns>The hero's damage.</returns>
        public abstract double Damage();

        /// <summary>
        /// Method creates and returns a string to display the hero's stats.
        /// </summary>
        /// <returns>The hero's stats.</returns>
        public override string ToString()
        {
            return $"Name: {Name}" + Environment.NewLine
                    + $"Level: {Level}" + Environment.NewLine
                    + $"Strength: {PrimaryAttributes.Strength}" + Environment.NewLine
                    + $"Dexterity: {PrimaryAttributes.Dexterity}" + Environment.NewLine
                    + $"Intelligence: {PrimaryAttributes.Intelligence}" + Environment.NewLine
                    + $"Damage: {Damage()}";
        }
    }
}
