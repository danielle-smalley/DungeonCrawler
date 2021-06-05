using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Instrument
    {
        //fields
        private int _minDamage;
        //props
        public int MaxDamage { get; set; }
        public string InstrumentName { get; set; }
        public int BonusHitChance { get; set; }
        public bool TwoHandsNeeded { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//end if
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }//end MinDamage

        //ctors
        public Instrument(int minDamage, int maxDamage, string instrumentName, int bonusHitChance, bool twoHandsNeeded)
        {
            //props that have business rules based off of other props go first
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            InstrumentName = instrumentName;
            BonusHitChance = bonusHitChance;
            TwoHandsNeeded = twoHandsNeeded;
        }

        //methods
        public override string ToString()
        {
            return string.Format("~*~*Equipped Instrument is: {0}*~*~\n" +
                "Damage: {1} to {2}\t" +
                "Bonus Hit Chance: {3}%\n" +
                "Requires both hands to swing? {4}\n", InstrumentName, MinDamage, MaxDamage, BonusHitChance, TwoHandsNeeded ? "Yes" : "No");
        }

    }//end class
}//end namespace
