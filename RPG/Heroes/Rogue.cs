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


        public override double Damage()
        {
            //Get DPS from weapon
            double dps = 1;
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
                    totalAttributes.Dexterity += armour.Attributes.Dexterity;
                }
            }

            //Calculate hero damage
            return dps * (1 + totalAttributes.Dexterity / 100);
        }
    }
}
