using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FunkyGhost : Boss
    {
        //ctors
        public FunkyGhost()
        {
            MaxHealth = 10;
            MaxDamage = 3;
            Name = "Funky Ghost";
            Health = 10;
            HitChance = 50;
            Block = 5;
            MinDamage = 1;
            BossDescription = "A funky ghost lurking around from discos of the past...";
        }

        //methods
        public override string ToString()
        {
            return base.ToString();
        }
    }//end class
}//end namespace
