using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Heroes
{
    public class Mage : Hero
    {
        public static Items.WeaponType[] AllowedW = { Items.WeaponType.Staff, Items.WeaponType.Wand };
        public static Items.ArmourType[] AllowedA = { Items.ArmourType.Cloth };

        public Mage(string name) : base(name, 1, 1, 8, 1, 1, 5, AllowedW, AllowedA) { }

    }
}
