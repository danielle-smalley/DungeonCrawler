using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary //Character serves as base class for player and monster.
{
    public abstract class Character //abstract used here - this modifier indicates that the thing being created isn't a complete implementation as you have to build a complete implementation in the child classes to be used in the game.
    {
        //fields
        private int _health;

        //props
        public string DancerName { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxHealth { get; set; }
        public int Health
        {
            get { return _health; }
            set
            {
                if (value <= MaxHealth)
                {
                    _health = value;
                }//end if
                else
                {
                    _health = MaxHealth;
                }//end else
            }//end set
        }//end Health
        //ctors - none
        //methods
        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0; //going to set this in Dancer and PartyPooper
        }

    }//end class
}//end namespace
