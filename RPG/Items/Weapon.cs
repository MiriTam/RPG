using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{

    public enum WeaponType
    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    }

    public class Weapon : Item
    {
        public WeaponType WeaponType { get; set; }
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }

        public Weapon(string name, int levelRequirement, Slot slot, WeaponType weaponType, double damage, double attackSpeed) : base (name, levelRequirement, slot)
        {
            WeaponType = weaponType;
            Damage = damage;
            AttackSpeed = attackSpeed;
        }

        /// <summary>
        /// Method calculates and returns the weapon's damage per second (DPS).
        /// </summary>
        /// <returns>Weapon's DPS.</returns>
        public double GetDPS()
        {
            return Damage * AttackSpeed;
        }
    }
}
