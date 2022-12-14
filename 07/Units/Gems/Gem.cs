using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    public abstract class Gem : IGem
    {
        private readonly int strengthBonus;
        private readonly int agilityBonus;
        private readonly int vitalityBonus;
        protected Gem(int strengthBonus, int agilityBonus, int vitalityBonus, GemClarity clarity)
        {
            this.strengthBonus = strengthBonus;
            this.agilityBonus = agilityBonus;
            this.vitalityBonus = vitalityBonus;
            Clarity = clarity;
        }
        public int StrengthBonus => strengthBonus + (int)Clarity;
        public int AgilityBonus => agilityBonus + (int)Clarity;
        public int VitalityBonus => vitalityBonus + (int)Clarity;
        public GemClarity Clarity { get; }
    }
}
