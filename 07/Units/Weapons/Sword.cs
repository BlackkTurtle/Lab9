using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public class Sword : Weapon
    {
        public Sword(WeaponRarity rarity) : base(4, 6, 3, rarity)
        {
        }
    }
}
