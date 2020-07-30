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
            Console.WriteLine("Alpaha Version 1.0000000000000000000.0");
            Console.WriteLine("press enter to go next!");

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


