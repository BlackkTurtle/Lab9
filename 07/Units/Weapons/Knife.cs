using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public class Knife : Weapon
    {
        public Knife(WeaponRarity rarity) : base(3, 4, 2, rarity)
        {
        }
    }
}
