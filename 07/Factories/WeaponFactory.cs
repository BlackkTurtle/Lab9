using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string typeName, string rarityName)
        {
            WeaponRarity rarity = (WeaponRarity)Enum.Parse(typeof(WeaponRarity), rarityName);

            return (IWeapon)Activator.CreateInstance(Type.GetType(typeName), rarity);
        }
    }
}
