using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Biggie : Boss
    {
        //props
        //ctors
        public Biggie()
        {
            MaxHealth = 25;
            MaxDamage = 6;
            Name = "BIGGIE";
            Health = 25;
            HitChance = 60;
            Block = 25;
            MinDamage = 2;
            BossDescription = "Well, they certainly aren't tiny...";
        }

        //methods
        public override string ToString()
        {
            return base.ToString();
        }

    }//end class
}//end namespace
