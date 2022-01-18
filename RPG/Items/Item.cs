using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{

    public abstract class Item
    {
        public string Name { get; set; }
        public int LevelRequirement { get; set; }
        public Slot Slot { get; set; }

        public Item(string name, int levelRequirement, Slot slot)
        {
            Name = name;
            LevelRequirement = levelRequirement;
            Slot = slot;
        }
        
    }
}
