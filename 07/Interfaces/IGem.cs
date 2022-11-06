using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public interface IGem
    {
        int AgilityBonus { get; }
        GemClarity Clarity { get; }
        int StrengthBonus { get; }
        int VitalityBonus { get; }
    }
}
