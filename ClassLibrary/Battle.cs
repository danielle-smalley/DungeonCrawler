using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Battle
    {
        //No fields, props, ctors since it's just storing combat functionality.

        //DoBattle() - dancer/boss attacks the other
        public static void DoAttack(Character attacker, Character defender) //assign an attacker and attackee
        {
            //Let's use a random dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 51);
            System.Threading.Thread.Sleep(1000);
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //attacker hit, calculate damage
                int damageDealt = attacker.CalcDamage();
                //assign the damage
                defender.Health -= damageDealt;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("{0} attacked {1} and dealt {2} damage!", attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }//end if
            else
            {
                Console.WriteLine("{0} missed {1}!\n", attacker.Name, defender.Name);
            }//end else
        }//end DoAttack()

        public static void DoBattle(Dancer dancer, Boss boss)
        {
            DoAttack(dancer, boss);
            if (boss.Health > 0)
            {
                DoAttack(boss, dancer); //while boss's health is above 0, attack sequence
            }//end if
        }//end DoBattle()
    }//end class
}//end namespace
