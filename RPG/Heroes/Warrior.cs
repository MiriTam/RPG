using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Heroes
{
    public class Warrior : Hero
    {
        public static Items.WeaponType[] AllowedW = { Items.WeaponType.Axe, Items.WeaponType.Hammer, Items.WeaponType.Sword };
        public static Items.ArmourType[] AllowedA = { Items.ArmourType.Mail, Items.ArmourType.Plate };

        public Warrior(string name) : base(name, 5, 2, 1, 3, 2, 1, AllowedW, AllowedA) { }
    }
}
