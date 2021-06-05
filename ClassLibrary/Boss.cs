using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Boss : Character
    {
        //fields
        private int _minDamage;
        //props
        public int MaxDamage { get; set; }
        public string BossDescription { get; set; }
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
        public Boss()
        {

        }

        public Boss(string name, int health, int maxHealth, int hitChance, int block, int minDamage, int maxDamage, string bossDescription)
        {
            MaxHealth = maxHealth;
            MaxDamage = maxDamage;
            Name = name;
            Health = health;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            BossDescription = bossDescription;
        }

        //methods
        public override string ToString()
        {
            return string.Format("\nX^X^X^BOSS^X^X^X\n" +
                "Bad guy/gal name: {0}\n" +
                "Health: {1} / {2}\n" +
                "Damage Range: {3} - {4}\t Block: {5}%\n" +
                "Description: \n{6}\n", Name, Health, MaxHealth, MinDamage, MaxDamage, Block, BossDescription);
        }

    }//end class
}//end namespace
