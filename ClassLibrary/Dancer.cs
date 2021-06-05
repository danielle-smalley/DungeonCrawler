using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public sealed class Dancer : Character //Dancer is child of Character class. Inherits fields, props, and methods. Sealed means I'm not  using this class as a base class for other classes, it's sealed off.
    {
        //fields - N/A
        //props
        public Persona DancerPersona { get; set; }
        public Instrument EquippedInstrument { get; set; }

        //ctors
        public Dancer(Persona dancerPersona, int hitChance, int block, int health, int maxHealth, Instrument equippedInstrument)
        {
            MaxHealth = maxHealth;
            DancerPersona = dancerPersona;
            HitChance = hitChance;
            Block = block;
            Health = health;
            MaxHealth = maxHealth;
            EquippedInstrument = equippedInstrument;
        }

        //methods
        public override string ToString()
        {
            return string.Format("~*~*{0}*~*~\n" +
                "Health: {1} / {2}\n" +
                "Hit Chance: {3}%\t" +
                "Block: {4}\n" +
                "{5}\n", DancerPersona, Health, MaxHealth, HitChance, Block, EquippedInstrument);
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedInstrument.MinDamage, EquippedInstrument.MaxDamage + 1); //have to add a plus one to get the actual max damage
            return damage;
        }

        public override int CalcHitChance()
        {
                return base.CalcHitChance() + EquippedInstrument.BonusHitChance; //taking the base hit return (hitchance) from Character and the equipped instrument's bonus hit chance
        }
    }//end class
}//end namespace
