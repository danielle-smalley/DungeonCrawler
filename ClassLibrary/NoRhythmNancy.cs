using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NoRhythmNancy : Boss
    {
        //fields - n/a
        //props - going to make Nancy stronger/more resilient after an early bedtime of 8:30pm (she gets grumpy)
        public DateTime SourHour { get; set; }

        //ctor
        public NoRhythmNancy(string name, int health, int maxHealth, int hitChance, int block, int minDamage, int maxDamage, string description):base(name, health, maxHealth, hitChance, block, minDamage, maxDamage, description)
        {
            SourHour = DateTime.Now;
            if (SourHour.Hour < 5 || SourHour.Hour > 20) //she's sour (grumpy) between 8pm and 5am
            {
                HitChance += 12;
                Block += 10;
                MaxDamage += 1;
            }//end if
        }//end SourHour


        //methods
        public override string ToString()
        {
            return string.Format("{0}\n{1}", base.ToString(), SourHour.Hour < 5 || SourHour.Hour > 20 ? "Nancy is SOUR, it is well past her bedtime!" : "Nancy looks even-tempered, as it's not close to her bedtime");
        }

    }//end class
}//end namespace
