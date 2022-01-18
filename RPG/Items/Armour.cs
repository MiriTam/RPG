using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    public enum ArmourType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }

    public class Armour : Item
    {
        public ArmourType ArmourType { get; set;}
        public Heroes.Primary Attributes { get; set;}

        public Armour(string name, int levelRequirement, Heroes.Slot slot, ArmourType armourType, Heroes.Primary attributes) : base(name, levelRequirement, slot)
        {
            ArmourType = armourType;
            Attributes = attributes;
        }
    }
}
