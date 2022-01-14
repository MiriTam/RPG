using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Heroes
{
    internal class Ranger : Hero
    {
        public static Items.WeaponType[] AllowedW = { Items.WeaponType.Bow };
        public static Items.ArmourType[] AllowedA = { Items.ArmourType.Leather, Items.ArmourType.Mail };

        public Ranger(string name) : base(name, 1, 7, 1, 1, 5, 1, AllowedW, AllowedA) { }

    }
}
