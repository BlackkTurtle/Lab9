using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public class GemFactory
    {
        public IGem CreateGem(string typeName, string clarityName)
        {
            GemClarity rarity = (GemClarity)Enum.Parse(typeof(GemClarity),clarityName);

            return (IGem)Activator.CreateInstance(Type.GetType(typeName), rarity);
        }
    }
}
