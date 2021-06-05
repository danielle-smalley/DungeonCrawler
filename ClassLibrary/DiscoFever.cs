using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DiscoFever : Boss
    {
        //fields - n/a
        //props
        public DateTime FeverTime { get; set; }
        //ctors
        public DiscoFever(string name, int health, int maxHealth, int hitChance, int block, int minDamage, int maxDamage, string description):base(name, health, maxHealth, hitChance, block, minDamage, maxDamage, description)
        {
            FeverTime = DateTime.Now;
            if(FeverTime.Hour < 6 || FeverTime.Hour > 23)
            {
                HitChance += 15;
                MinDamage += 3;
                MaxDamage += 5;
                Health += 5;
            }//end if
        }//end DiscoFever()

        //methods
        public override string ToString()
        {
            return string.Format("{0}\n{1}", base.ToString(), FeverTime.Hour < 5 || FeverTime.Hour > 23 ? "DISCO INFERNO!!!" : "No disco fever.");
        }
    }//end class
}//end namespace
