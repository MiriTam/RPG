using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    enum ArmourType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }

    internal class Armour : Item
    {
        public ArmourType Type { get; set;}
        public Heroes.Primary Attributes { get; set;}

        public Armour(string name, int levelRequirement, Heroes.Slot slot, ArmourType type, Heroes.Primary attributes) : base(name, levelRequirement)
        {
            Type = type;
            Attributes = attributes;
        }
    }
}
