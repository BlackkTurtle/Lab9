using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public interface IWeapon
    {
        int AgilityBonus { get; }
        int MaxDamage { get; }
        int MinDamage { get; }
        WeaponRarity Rarity { get; }
        int StrengthBonus { get; }
        int VitalityBonus { get; }

        void AddGem(IGem gem, int index);
        void RemoveGem(int index);
    }
}
