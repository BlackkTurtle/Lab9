using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public class Axe : Weapon
    {
        public Axe(WeaponRarity rarity) : base(5, 10, 4, rarity)
        {
        }
    }
}
