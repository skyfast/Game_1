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
            

            char test;

            test = curLevel.PlayerBoardMove();
            Console.WriteLine(test);
            if (curLevel.validateBoardMove(test))
                Console.WriteLine("good!");
            else
                Console.WriteLine("Bad!");
            Console.ReadLine();


        }
    }
}
