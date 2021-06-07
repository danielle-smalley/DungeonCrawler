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
            Thread.Sleep(1000);
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

            int wins = 0;  //score running total so I can display


            //TODO QUESTION - how do I use these instruments I've created so the user can choose one? And how do I keep it "stuck" to the player once they've chosen it, and possibly let them change instrument during the game?
            #region Instruments Created
            Instrument keyboard = new Instrument(1, 5, "Krazy Keyboard", 10, true, "A large keyboard for all of your piano and synth needs. It's pretty heavy. Watch the cords!");
            Instrument highHat = new Instrument(1, 4, "Hellacious High Hat", 8, false, "A high hat from a drum set. It is very versatile. CRASH!");
            Instrument bass = new Instrument(2, 6, "Bomb Bass", 12, true, "Bass...like a guitar, except it carries the song and everyone ignores it.");
            Instrument horn = new Instrument(1, 3, "Da Trumpet", 13, false, "Hard to ignore, this is one shiny trumpet.");
            Instrument sax = new Instrument(2, 5, "Snazzy Saxophone", 9, true, "To quote Homere Simpson, 'Saxomophone'.");
            Instrument[] instruments = { keyboard, highHat, bass, horn, sax };
            Console.WriteLine(instruments);

            Console.WriteLine("Which instrument do you grab as your weapon? \n" +
                "K) Keyboard\n" +
                "H) High Hat\n" +
                "B) Bass\n" +
                "T) Trumpet\n" +
                "S) Saxophone\n");
            ConsoleKey pickedInstrument = Console.ReadKey(true).Key;
            Console.Clear();

            switch (pickedInstrument)
            {
                case ConsoleKey.K:
                    #region insKeyboard
                    string insKeyboard = @"
                || | | ||| | ||| | | ||| | ||| | | ||| | ||| | | ||| | ||| | | ||
                ||_|_|_|||_|_|||_|_|_|||_|_|||_|_|_|||_|_|||_|_|_|||_|_|||_|_|_||
                | | | | | | | | | | | | | | | | | | | | | | | | | | | | | | | | |
                |_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|
                        ";
                    Console.WriteLine(insKeyboard);
                    #endregion
                    Console.WriteLine("Keyboard, alright!");
                    break;

                case ConsoleKey.H:
                    #region insHighHat
                    string insHighHat = @" 
                        ==I==
                          |
                          |
                         /|\
                        //| \
                        ";
                    Console.WriteLine(insHighHat);
                    #endregion
                    Console.WriteLine("High Hat, right on!");
                    break;

                case ConsoleKey.B:
                    #region insBass
                    string insBass = @" 
             _
            /;)
           /;(
           >_/
           |-|
           |-|
           |-|
           |-|
           |-|
           |-|
           |-|
       _   |-|
      / \  |-|   _
     :   `'|-|  /,\
     :   ,`'-'`'/|:
      \  \ ...   ;/
       :  )...  ::
       ; / ...  ::
      / /  ___   \\
     :  `-|||||.  \:
     :        (\`-';
      `._________,' 
                        ";
                    Console.WriteLine(insBass);
                    #endregion
                    Console.WriteLine("Bass, that's bomb!");
                    break;

                case ConsoleKey.T:
                    #region insTrumpet
                    string insTrumpet = @" 
                     /|
       =  =  =      / |
  ____| || || |____/  | -_-_-_-_-_-_
|)----| || || |____   |    
  ((  | || || |  ))\  | _-_-_-_-_-_-
   \\_|_||_||_|_//  \ |
    \___________/    \|
                        ";
                    Console.WriteLine(insTrumpet);
                    #endregion
                    Console.WriteLine("Trumpet, far out!");
                    break;

                case ConsoleKey.S:
                    #region insSax
                    string insSax = @" 
  _,-----,____g===;,
<'.._____,-------g  ;
                   \   \,
                     q   q,
                      q    q,
                     [='     q
                       `;  O  p
                         k  O  p -{0
                          l  O  p -o
                          ,i     p
                           P  O   |
                         q:|   O| |BD
                            [   | P b
                            |   |  |____________
                          [ |   |  |\         /
                          | '   |  P :       ;
                          | [   0   Q:  ( )  ;
                           [ P  ( )  |;  ( ) ;
                           :Q  ( )  V        p
                            \   [           ;
                             \',     O    /
                               ' ; _ . '
                        ";
                    Console.WriteLine(insSax);
                    #endregion
                    Console.WriteLine("Saxophone, so smooth!");
                    break;

                default:
                    string noChoice = @"
        __________
       1          1
       1          1
       1          1
  ____ 1     ____ 1
 /    \1    /    \1
1      1   1      1
 \____/     \____/
                        ";
                    Console.WriteLine(noChoice);
                    Console.WriteLine("You gotta pick one, don't wanna be empty handed!");
                    break;
            }//end switch

            #endregion

            //create the player
            //TODO QUESTION - similar to the above with instruments, how do I let user choose from the names (Personas) I've created?
            Dancer dancer = new Dancer(Persona.BananasBob, 65, 10, 20, 20, keyboard);

            //TODO QUESTION- name of dancer missing in the battle scene printout - I'm using the names in Persona enum (wanting user to get to choose which one), I can't figure out how to call to this correctly in my class?
            //TODO - tidy up console colors and clears.

            //Create the outer loop, for the room (dance floor/scene) and boss
            bool exit = false;

            do
            {
                //create a boss array
                ToneDeafTony t1 = new ToneDeafTony();
                ToneDeafTony t2 = new ToneDeafTony("Fiesty Tony", 20, 20, 60, 10, 1, 5, "He's a spicier version of himself...he's obviously had a few", true);
                NoRhythmNancy r1 = new NoRhythmNancy("No Rhythm Nancy", 10, 10, 30, 8, 1, 3, "Nancy gets in the way of dancing as she seems to possess zero rhythm detection skills. When it's past her bedtime, watch out!");
                DiscoFever d1 = new DiscoFever("Disco Fever!", 20, 20, 65, 10, 2, 6, "Hey hey hey, boogie fever!");
                FunkyGhost f1 = new FunkyGhost();
                Biggie b1 = new Biggie();
                Boss[] bosses = { t1, t2, r1, d1, f1, b1 };

                //load a room
                Thread.Sleep(250);
                Console.WriteLine(GetDanceFloor());
                Thread.Sleep(1000);

                //Randomly select a boss to fight
                Random rand = new Random();
                int randomNbr = rand.Next(bosses.Length);
                Boss boss = bosses[randomNbr]; //returns a random int and the overload for this is the max value (however many bosses we have = bosses.Length. Then call to random index in the array to select/choose boss.

                //Show the boss in the room
                Console.WriteLine(boss.Name + "!");

                bool reload = false; //helps us when we need to either reload a room or not

                //create inner loop for menu
                do
                {
                    #region menu

                    Thread.Sleep(250);
                    Console.Write("\nWhat will you do now?\n" +
                        "C) Challenge to a Dance Battle/Dance Again!\n" +
                        "I) Swap out Instrument\n" +
                        "S) Sneak Outta This Joint\n" +
                        "D) Dancer Deets\n" +
                        "B) Boss Deets\n" +
                        "Q) Quit This Groovy Game\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        //handle challenge/attack sequence functionality
                        case ConsoleKey.C:
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Bust a move!");
                            Battle.DoBattle(dancer, boss); //user attacks boss
                            if (boss.Health <= 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\nYou WIN the dance battle! You're the grooviest! {0} has lost and runs home, crying.\n", boss.Name);
                                #region victory music
                                Console.Beep(784, 100); //G
                                Console.Beep(784, 100); //G
                                Console.Beep(784, 100); //G
                                Console.Beep(784, 400); //G
                                Console.Beep(622, 300); //Eb
                                Console.Beep(698, 300); //F
                                Console.Beep(784, 500); //G
                                Console.Beep(698, 100); //F
                                Console.Beep(784, 700); //G
                                #endregion
                                Console.WriteLine("You collect a bonus of 7 health points to restore some health.\n");
                                dancer.Health += 7; //adding a bonus where user gets +5 health for each win
                                Console.ResetColor();
                                reload = true; //exits inner loop so a new dancefloor and boss are loaded
                                wins++;
                            }//end if
                            break;

                        case ConsoleKey.I:
                            Console.WriteLine("Which instrument would you like?");
                            Console.WriteLine(instruments);
                            //TODO - 
                            break;

                        case ConsoleKey.S:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You book it and boogy on outta there...\n");
                            ////handle run away logic
                            Console.WriteLine("{0} throws one of their platform heels at you as you run away like a coward!\n", boss.Name);
                            Battle.DoAttack(boss, dancer);
                            Console.WriteLine();
                            reload = true;
                            break;

                        case ConsoleKey.D:
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Dancer Info");
                            //handle showing player info
                            Console.WriteLine(dancer);
                            Console.WriteLine("Dance Battles Won: " + wins);
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("Boss Info");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            //handle showing challenge info/preview
                            Console.WriteLine(boss);
                            break;

                        case ConsoleKey.Q:
                        case ConsoleKey.Escape:
                        case ConsoleKey.X:
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Leaving the disco. Peace, love, and granola.");
                            Console.WriteLine("You won " + wins + " dance battle" + (wins == 1 ? "." : "s."));
                            #region exitmusic
                            Console.Beep(196, 600);
                            Console.Beep(247, 600);
                            Console.Beep(262, 900);
                            #endregion
                            exit = true; //exits both inner & outer loops
                            break;

                        default:
                            Console.WriteLine("That wasn't one of the choices...keep on steppin'!");
                            break;
                    }//end switch
                    #endregion

                    //check the dancer's health left
                    if (dancer.Health <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        #region losemusic
                        Console.Beep(784, 100);
                        Console.Beep(740, 200);
                        Console.Beep(659, 200);
                        Console.Beep(622, 200);
                        Console.Beep(523, 300);
                        Console.Beep(415, 200);
                        Console.Beep(392, 500);
                        #endregion
                        Console.WriteLine($"{boss.Name} has danced circles around you. You die of shame and embarrassment, and ascend to Disco Afterlife.");
                        Console.WriteLine("You won " + wins + " dance battle" + (wins == 1 ? "" : "s") + " during your funky life!");
                        exit = true;
                    }//end if
                     //handle if player's life is out, display score and message

                } while (!exit && !reload); //end inner do while
            } while (!exit); //end outer do while


        }//end main

        //create a collection of different rooms
        #region GetDanceFloor(load room)
        private static string GetDanceFloor() 
        {
            string[] danceFloors =
            {"Walking through Manhattan, you hear fabulous music by the lovely Donna Summer pumping from a nightclub. The sign reads 'Studio 54'. You're ready to move and groove, so you open the door. A bustling scene unfolds in front of you, but you're here for one thing only--to DANCE! You start making your way to the dancefloor, but someone shoulder checks you on your way there. You turn around to see...", "It's a summer night in Manhattan, you're with your friends at the Crisco Disco dancing the night away. As Kool & the Gang blares, you lose your balance, falling into an angry figure. You look up and see...", "You and your friends hit up the local roller rink. You march in prepared in matching outfits, pre-planned dance routines, and a $10 bill slipped to the DJ means a perfect playlist. Earth, Wind & Fire queues up on the speakers, and you skate out into the rink. Then, your worst enemies arrive with a new friend who steps forward ominously towards you...", "It's 2020 so you're dancing in your home alone to some Diana Ross and Bee Gees. You learned some moves from Tik Tok and Snapchat and think you're dancing GREAT. You tell Alexa to turn the music up to max volume, and shortly after hear a loud, angry knock at your door. You open the door to see...", "You're an up and coming DJ at a local nightclub. The club gave you some pop songs/today's hits to spin but the energy in the crowd is lower than low. Instead of panicking, you throw on some Prince, Gloria Gaynor, James Brown, and the like. The energy shifts, and you feel the power! However, a disgruntled club manager starts approaching you, and calls over a bouncer.  You look behind the manager and see..."}; //end string
        //generate a random object - 
        Random rand = new Random();
            int indexNbr = rand.Next(danceFloors.Length);
            string DanceFloor = danceFloors[indexNbr];
            return DanceFloor;
        }//end GetDanceFloor()
        #endregion
    }//end class
}//end namespace
