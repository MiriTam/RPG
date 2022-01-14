using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{

    enum WeaponType
    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    }

    internal class Weapon : Item
    {
        public WeaponType WeaponType { get; set; }
        public int Damage { get; set; }
        public int AttackSpeed { get; set; }

        public Weapon(string name, int levelRequirement, Heroes.Slot slot, WeaponType weaponType, int damage, int attackSpeed) : base (name, levelRequirement, slot)
        {
            WeaponType = weaponType;
            Damage = damage;
            AttackSpeed = attackSpeed;
        }
       
        public int GetDPS()
        {
            return Damage * AttackSpeed;
        }
    }
}
