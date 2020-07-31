using Game.Story;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //display the intro
            Intro.DisplayIntro();

            //get the 'player' name
            Player curPlayer = new Player(Intro.GetName());

            Level curLevel = new Level(1);
            curLevel.DisplayBoard(curPlayer);
            Console.ReadLine();
          
           
        }
    }
}
