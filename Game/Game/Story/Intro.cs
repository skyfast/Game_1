using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{

    public class Intro
    {
        //This class will handle everything in the begingin of the game.
        
        //display the into sequince
        public static void DisplayIntro()
        {
            Console.WriteLine("Welcome to game #1");
            Console.WriteLine("Alpaha Version 1.0000000000000000000.1");
            Console.WriteLine("press enter to go next!");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("This version is a POC and there is much more I plan to add.");
            Console.WriteLine("There is no story yet and the combat has not been tuned at all.");
            Console.WriteLine("I do however appreciate any feed back you may have");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Use w a s d for movement.");
            Console.WriteLine("The goal is to get to the end of the dungeon before hitting 0 hp");
            Console.WriteLine("There are also pick ups you can get while you travel around.");
            Console.WriteLine("There are 3 special attacks and your normal weak attack");
            Console.WriteLine("specail attacks take DP and will fail if you run out.");

            Console.ReadLine();
            Console.Clear();
        }
       
        //get the players name and return it.
        public static string GetName()
        {
            Console.WriteLine("What is my name?");
            return Console.ReadLine();
        }

        public static void DisplayProlog()
        {

        }
    }
}


