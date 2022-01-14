using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Heroes
{
    internal class Warrior : Hero
    {
        public Warrior(string name) : base(name, 5, 2, 1, 3, 2, 1) { }
    }
}
