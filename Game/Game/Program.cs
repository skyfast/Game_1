using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
           //place holder, will make a player class to hold this later
            string pName = "";
            
            //display the intro
            Intro.DisplayIntro();

            //get the 'player' name
            Player curPlayer = new Player(Intro.GetName());

            Console.WriteLine("Name {0}", curPlayer.Name);
            Console.ReadLine();
          
           
        }
    }
}
