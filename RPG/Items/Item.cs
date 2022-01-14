using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{

    internal abstract class Item
    {
        public string Name { get; set; }
        public int LevelRequirement { get; set; }

        public Item(string name, int levelRequirement)
        {
            Name = name;
            LevelRequirement = levelRequirement;
        }
        
    }
}
