using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace DungeonApp
{
    class Gameplay
    {
        static void Main(string[] args)
        {
            Console.Title = "Disco Dungeon";
            Console.WriteLine("Time to face the music...");
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

            //TODO - load a room
            //Console.WriteLine(GetRoom());

            //TODO - Randomly select a challenge to fight

            //TODO - Show the monster/challenge in the room
            //Console.WriteLine("\nIn this room: " + monster.Name/challenge.Name);

            //TODO - create inner loop for menu

            bool reload = false;

            do
            {
                Console.Write("What will you do now?\n" +
                    "F) Face the Music!\n" +
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
                        Console.WriteLine("Sneak out the back...");
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
                        Console.WriteLine("Challenge Info");
                        //TODO - handle showing challenge info/preview
                        //Console.WriteLine(challenge);
                        break;

                    case ConsoleKey.Q:
                    case ConsoleKey.Escape:
                        Console.WriteLine("Leaving the disco");
                        //exit = true;
                        break;

                    default:
                        Console.WriteLine("That wasn't one of the choices...try again!");
                        break;
                }//end switch

                //TODO - check the players life left
                //handle if player's life is out, display score and message

            } while (!exit && !reload);

            //Display score for player upon exiting 

        }//end main

        //TODO - create a collection of different rooms
        //private static string GetRoom() 
        //{
        //string[] rooms = 
        //{(paste each description here)
        //TODO - generate a random object - Rnadom rand - new Random();
        //Generate a random index number using Next() - int indexNbr = rand.Next(rooms.Length);
        //Create a string for the single room that will be returned - string room - rooms[indexNbr];
        //Return the room - return room;
        //}end string rooms
        //}end GetRoom()
    }//end class
}//end namespace
