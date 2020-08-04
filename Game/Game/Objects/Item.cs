using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Objects
{
    //this class handels loading items when a player walkes over them \
    public class Items
    {
        public static Random gen = new Random();

        //get a random 
        public static void GetItem(Player curPlayer)
        {
            int x = gen.Next(1, 106);

            if(x > 45)
            {
                HealthItem(curPlayer);
            }
            else if(x < 80)
            {
                DreamItem(curPlayer);
            }
            else if(x < 95)
            {
                PogItem(curPlayer);
            }
            else
            {

            }
        }

        //code for a healt item
        public static void  HealthItem(Player curPlayer)
        {
            curPlayer.MaxHp += 5;
            curPlayer.Hp += 5;

            Console.Clear();
            Console.WriteLine("You found something very nice");
            Console.WriteLine("You feel very happy!");
            Console.WriteLine("hp + 5!");
            Console.ReadLine();
        }

        public static void DreamItem(Player curPlayer)
        {
            curPlayer.MaxDp += 5;
            curPlayer.Dp += 5;
            Console.Clear();
            Console.WriteLine("You find something very confy");
            Console.WriteLine("You feel a little more rested!");
            Console.WriteLine("dp + 5!");
            Console.ReadLine();
        }

        public static void PogItem(Player curPlayer)
        {
            curPlayer.MaxHp += 10;
            curPlayer.Hp += 10;
            curPlayer.MaxDp += 10;
            curPlayer.Dp += 10;

            Console.Clear();
            Console.WriteLine("You find a pog");
            Console.WriteLine("POG!");
            Console.WriteLine("dp and hp + 10!");
            Console.ReadLine();
        }

        public static void TrollItem(Player curPlayer)
        {
            curPlayer.MaxHp -= 5;
            curPlayer.MaxDp -= 5;

            if(curPlayer.Hp > curPlayer.MaxHp)
            {
                curPlayer.Hp = curPlayer.MaxHp;
            }

            if (curPlayer.Dp > curPlayer.MaxDp)
            {
                curPlayer.Dp = curPlayer.MaxDp;
            }

            Console.Clear();
            Console.WriteLine("You find a gnelf");
            Console.WriteLine("No wait... a gnoblen?");
            Console.WriteLine("...Oh No.. it's a gnome...");
            Console.WriteLine("YOU HAVE BEEN GNOMED!!!!!!!!!!");
            Console.ReadLine();
        }
    }
}
