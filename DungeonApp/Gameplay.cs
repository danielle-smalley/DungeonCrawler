using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ClassLibrary;

namespace DungeonApp
{
    class Gameplay
    {
        static void Main(string[] args)
        {
            Console.Title = "Discotheque Dungeon";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Welcome to...");
            Thread.Sleep(2000);
            Console.WriteLine("the Discotheque Dungeon!");
            Thread.Sleep(2000);
            #region disco
            string disco = @"
________________________________________________
                      |
                      |            .'
                  \   |   /
               `.  .d88b.   .'
                  d888888b
      --     --  (88888888)  --
                  Y888888Y
              .'   `Y88Y'   `.
                  /       \
           .'         !        `.
       .,,-~&,,              ,~''~.
      { / ___ /\`.           > ::::
     { `}'~.~/\ \   ` `     <, ?::;
     {`}'\._/  ) }   ) )     l_  f
      ,__ / l_,'-/  .'.'    ,__}--{_.
     {  `.__.' (          /          }
      \ \    )  )        /           !
       \-\`-'`-'         /  ,   1  J;
  ` `   \ \___l,-_,___.'  /1    !  Y
   ) )   k____ - ~'-l_____.'|   l /
 .'.'   /===#==\           l     f
      .'        `.         I===I=I
    ,' ,'       `.`.       f     }
  ,' ,' /      \ `.`.      |     }
.'^.^.^.'`.'`.^.'`.'`.^.   l    Y;
           `.   \          }    |
            !`,  \         |    |
            l /   }       ,1    |
            l/   /        !l   ,l
            /  ,'         ! \    \
           /  /!          !  \    \
    ' '   / ,f l          l___j.   \
   ( (   (_ \l_ `_    ,.-'`--(  `.,'`.
    `.`.  Y\__Y`--'   `-'~x__J    j'  >
                                ,/ ,^'
                               f__J 
------------------------------------------------
";
            Console.WriteLine(disco);
            #endregion
            Console.WriteLine("Time to face the music...");

            #region Music
            Console.Beep(1109, 500); //Db
            Console.Beep(1175, 250); //D
            Console.Beep(1109, 750); //Db            
            Console.Beep(1109, 250); //Db
            Console.Beep(1175, 250); //D
            Console.Beep(1109, 250); //Db
            Console.Beep(988, 500); //B
            Console.Beep(880, 500); //A
            Console.Beep(988, 450); //B
            Console.Beep(1109, 500); //Db
            Console.Beep(1175, 250); //D
            Console.Beep(1109, 750); //Db            
            Console.Beep(1109, 250); //Db
            Console.Beep(1175, 250); //D
            Console.Beep(1109, 250); //Db            
            Console.Beep(988, 500); //B
            Console.Beep(880, 500); //A
            Console.Beep(988, 450); //B
            Console.Beep(1109, 500); //Db
            Console.Beep(1175, 250); //D
            Console.Beep(1109, 750); //Db            
            Console.Beep(1109, 250); //Db
            Console.Beep(1175, 250); //D
            Console.Beep(1109, 250); //Db            
            Console.Beep(988, 450); //B
            Console.Beep(880, 750); //A
            Console.Beep(740, 200); //F#
            Console.Beep(988, 750); //B
            Console.Beep(880, 1000); //A
            Thread.Sleep(250);
            #endregion

            //TODO - create classes for character, player, challenge/monster and various types, weapon/dance move, race type of enum?, combat/challenge sequence class.
            //Challenge name : Challenge/Monster (create child/parent relationship
            //Monster/Challenge : Character
            //Player/Dancer : Character



            //score running total
            int wins = 0;

            //TODO - create the player
            //create dance moves and equip the player with a dance move. Give the player the ability to change their equipped dance move.
            //Define dance move here
            //Define Player here

            //TODO - Create the outer loop, for the room (dance floor?) and challenge
            bool exit = false;
            //start the do part of loop and put everything in here--outer loop while is while(!exit);
            //Inner loop will be the menu and while will be while (!exit && !reload); these should both be true.
            //Inside inner loop, do will contain menu and bool reload = false;

            //TODO - create a monster/challenge array

            //load a room
            Thread.Sleep(250);
            Console.WriteLine(GetDanceFloor());
            Thread.Sleep(1000);
            //Console.WriteLine(GetRoom());

            //TODO - Randomly select a challenge to fight

            //TODO - Show the monster/challenge in the room
            //Console.WriteLine("\nIn this room: " + monster.Name/challenge.Name);

            //create inner loop for menu

            bool reload = false;

            do
            {
                Thread.Sleep(250);
                Console.Write("What will you do now?\n" +
                    "F) Challenge them to a Dance Battle!\n" +
                    "S) Sneak Out\n" +
                    "D) Dancer Info\n" +
                    "C) Challenge Info/Preview\n" +
                    "Q) Quit the Game\n");

                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.F:
                    Console.WriteLine("Here comes your challenge!");
                        break;
                    //TODO--handle challenge/attack sequence functionality
                    //When player attacks monster
                    //When monster is dead
                    //When monster attacks player
                    //When player is dead
                    //Reload new room & monster
                    //reload = true to exit inner loop
                    //Add to player's score wins++
                    case ConsoleKey.S:
                        Console.WriteLine("You book it and boogy on outta there...");
                        //TODO - handle run away logic
                        //player takes a hit for running away?  Half a hit?
                        //reload=true;
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("Dancer Info");
                        //TODO - handle showing player info
                        //Console.WriterLine(dancer);
                        //Console.WriteLine("Challenges Won: " + wins);
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine("Challenger Info");
                        //TODO - handle showing challenge info/preview
                        //Console.WriteLine(challenge);
                        break;

                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        Console.WriteLine("Leaving the disco. Peace, love, and granola.");
                        //exit = true;
                        break;

                    default:
                        Console.WriteLine("That wasn't one of the choices...keep on steppin'!");
                        break;
                }//end switch

                //TODO - check the players life left
                //handle if player's life is out, display score and message

            } while (!exit && !reload);

            //Display score for player upon exiting 

        }//end main

        //create a collection of different rooms
        private static string GetDanceFloor() 
        {
            string[] danceFloors =
            {"Walking through Manhattan, you hear fabulous music by the lovely Donna Summer pumping from a nightclub. The sign reads 'Studio 54'. You're ready to move and groove, so you open the door. A bustling scene unfolds in front of you, but you're here for one thing only--to DANCE! You start making your way to the dancefloor, but someone shoulder checks you on your way there. You turn around to see...", "It's a summer night in Manhattan, you're with your friends at the Crisco Disco dancing the night away. As Kool & the Gang blares, you lose your balance, falling into an angry figure. You look up and see...", "You and your friends hit up the local roller rink. You march in prepared in matching outfits, pre-planned dance routines, and a $10 bill slipped to the DJ means a perfect playlist. Earth, Wind & Fire queues up on the speakers, and you skate out into the rink. Then, your worst enemies arrive with a new friend who steps forward ominously towards you...", "It's 2020 so you're dancing in your home alone to some Diana Ross and Bee Gees. You learned some moves from Tik Tok and Snapchat and think you're dancing GREAT. You tell Alexa to turn the music up to max volume, and shortly after hear a loud, angry knock at your door. You open the door to see...", "You're an up and coming DJ at a local nightclub. The club gave you some pop songs/today's hits to spin but the energy in the crowd is lower than low. Instead of panicking, you throw on some Prince, Gloria Gaynor, James Brown, and the like. The energy shifts, and you feel the power! However, a disgruntled club manager starts approaching you, and calls over a bouncer.  You look behind the manager and see..."}; //end string
        //generate a random object - 
        Random rand = new Random();
            int indexNbr = rand.Next(danceFloors.Length);
            string DanceFloor = danceFloors[indexNbr];
            return DanceFloor;
        }//end GetRoom()
    }//end class
}//end namespace
