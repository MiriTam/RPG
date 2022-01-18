using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Heroes
{
    public class Rogue : Hero
    {
        public static Items.WeaponType[] AllowedW = {Items.WeaponType.Dagger, Items.WeaponType.Sword};
        public static Items.ArmourType[] AllowedA = { Items.ArmourType.Leather, Items.ArmourType.Mail };

        public Rogue(string name) : base(name, 2, 6, 1, 1, 4, 1, AllowedW, AllowedA) { }

    }
}
