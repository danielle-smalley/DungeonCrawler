using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ToneDeafTony : Boss
    {
        //props
        public bool IsBelligerent { get; set; }

        //ctors
        public ToneDeafTony(string name, int health, int maxHealth, int hitChance, int block, int minDamage, int maxDamage, string description, bool isBelligerent):base(name, health, maxHealth, hitChance, block, minDamage, maxDamage, description)
        {
            IsBelligerent = isBelligerent;
        }

        public ToneDeafTony()
        {
            MaxHealth = 25;
            MaxDamage = 6;
            Name = "Tone Deaf Tony";
            Health = 25;
            HitChance = 25;
            Block = 20;
            MinDamage = 2;
            BossDescription = "A real New Jersey tough guy. He only has one volume = loud.";
            IsBelligerent = true;
        }

        public override string ToString()
        {
            return base.ToString() + (IsBelligerent ? "Belligerent" : "Strangely calmer than usual");
        }

        //If he's belligerent (too many drinks?), he is stronger but less block ability
        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (IsBelligerent)
            {
                calculatedBlock -= calculatedBlock / 2; //reducing his block by half
            }//end if
            return calculatedBlock;
        }//end CalcBlock()

        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;
            if (IsBelligerent)
            {
                calculatedDamage += calculatedDamage * 2; //increasing his damage to double
            }
            return calculatedDamage;
        }//end calcdamage()

        public override int CalcHitChance()
        {
            int calculatedHitChance = HitChance;
            if (IsBelligerent)
            {
                calculatedHitChance -= calculatedHitChance / 4; //lowering his chance to hit (his aim would be off due to imbibing) by 25%
            }//end if
            return calculatedHitChance;
        }//end calchitchance()


    }//end calcblock()
    }//end class
}//end namespace
