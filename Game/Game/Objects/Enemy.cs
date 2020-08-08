using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Game.Objects
{
    //is the enemy the player will have to fight
    //will also have the fight in this class
    class Enemy
    {
        private string name;
        private char type;
        private int hp;
        private int maxHp;

        static private Random gen = new Random();

        public Enemy(string nam, char typ, int h)
        {
            name = nam;
            type = typ;
            hp = h;
            maxHp = h;

        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public char Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Maxhp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }


        //sets up the fight 
        public void FightSetUp(Player curPlayer)
        {
            //keeps track of the fighting
            bool fighting = true;

            //used for the players intput
            char playerKey;

            while(fighting)
            {
                //print out hud
                FightHUD(curPlayer);
                //get the players move, then carry it out
                playerKey = GetAction();
                MakePlayerFightMove(ref fighting, playerKey, curPlayer);

                //if the enemy is not at 0 or leess hp, it attacks
                if(fighting && this.Hp > 0)
                {
                    EnemyAttack(curPlayer);
                }

                //end fight if someone is at 0 hp
                if(this.Hp <=0 || curPlayer.Hp <=0)
                {
                    fighting = false;
                }
            }
        }

        //resolves the players move
        public void MakePlayerFightMove(ref bool fighting, char m, Player curPlayer)
        {
            if(m == 'q')
            {
                RunPlayerAttack(ref fighting, curPlayer);
            }
            else if(m == 'w')
            {
                NormalPlayerAttack(curPlayer);
            }
            else if(m == 'f')
            {
                ChargePlayerAttack(curPlayer);
            }
            else
            {
                SpecialPlayerAttack(curPlayer, m);
            }
        }


        //----Player Attack Methods----
        public void NormalPlayerAttack(Player curPlayer)
        {
            this.Hp -= 1;
            Console.Clear();
            Console.WriteLine("{0} hits {1}. -1hp", curPlayer.Name, this.Name);
            Console.ReadLine();
        }

        public void ChargePlayerAttack(Player curPlayer)
        {
            if (curPlayer.Charge == false)
            {
                curPlayer.Charge = true;
                Console.Clear();
                Console.WriteLine("{0} charges the next attack", curPlayer.Name);
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} charges... again?", curPlayer.Name);
                Console.ReadLine();
            }

        }

        public void RunPlayerAttack(ref bool fighting, Player curPlayer)
        {
            int chance = gen.Next(1, 5);
            if (chance > 4)
            {
                Console.Clear();
                Console.WriteLine("{0} tried to run but failed...", curPlayer.Name);
                Console.ReadLine();
            }
            else
            {
                fighting = false;
                Console.WriteLine("{0} ran away!", curPlayer.Name);
                Console.Clear();
            }
        }

        //this method will call the correct attack
        public void SpecialPlayerAttack(Player curPlayer, char playerAttack)
        {
            Console.Clear();
            //if the player is out of dp, end the move
            if (curPlayer.Dp <= 0)
            {
                Console.WriteLine(FailedAttack(curPlayer));
                Console.ReadLine();
                return;
            }
            else
            {
                curPlayer.Dp -= 1;
            }
            
            
            if (playerAttack == 'a')
            {
                SpecialAttackA(curPlayer);
            }
            else if(playerAttack == 's')
            {
                SpecialAttackS(curPlayer);
            }
            else if(playerAttack =='d')
            {
                SpecialAttackD(curPlayer);
            }    
        }

        //---Special attacks---
        public void SpecialAttackA(Player curPlayer)
        {
            
            if(curPlayer.Charge)
            {
                if(this.type == 'd')
                {
                    this.Hp -= 1;
                    Console.WriteLine(BadAttack(curPlayer));
                }
                else if(this.Type == 's')
                {
                    this.Hp -= 10;
                    Console.WriteLine(GoodAttackCharged(curPlayer));
                }
                else if(this.Type == 'a')
                {
                    this.Hp -= 3;
                    Console.WriteLine(NormalAttackCharged(curPlayer));
                }
            }
            else
            {
                if (this.type == 'd')
                {
                    this.Hp -= 1;
                    Console.WriteLine(BadAttack(curPlayer));
                }
                else if (this.Type == 's')
                {
                    this.Hp -= 4;
                    Console.WriteLine(GoodAttack(curPlayer));
                }
                else if (this.Type == 'a')
                {
                    this.Hp -= 2;
                    Console.WriteLine(NormalAttack(curPlayer));
                }
            }
        }

        public void SpecialAttackS(Player curPlayer)
        {

            if (curPlayer.Charge)
            {
                if (this.type == 'a')
                {
                    this.Hp -= 1;
                    Console.WriteLine(BadAttack(curPlayer));
                }
                else if (this.Type == 'd')
                {
                    this.Hp -= 10;
                    Console.WriteLine(GoodAttackCharged(curPlayer));
                }
                else if (this.Type == 's')
                {
                    this.Hp -= 3;
                    Console.WriteLine(NormalAttackCharged(curPlayer));
                }
            }
            else
            {
                if (this.type == 'a')
                {
                    this.Hp -= 1;
                    Console.WriteLine(BadAttack(curPlayer));
                }
                else if (this.Type == 'd')
                {
                    this.Hp -= 4;
                    Console.WriteLine(GoodAttack(curPlayer));
                }
                else if (this.Type == 's')
                {
                    this.Hp -= 2;
                    Console.WriteLine(NormalAttack(curPlayer));
                }
            }
        }

        public void SpecialAttackD(Player curPlayer)
        {

            if (curPlayer.Charge)
            {
                if (this.type == 's')
                {
                    this.Hp -= 1;
                    Console.WriteLine(BadAttack(curPlayer));
                }
                else if (this.Type == 'a')
                {
                    this.Hp -= 10;
                    Console.WriteLine(GoodAttackCharged(curPlayer));
                }
                else if (this.Type == 'd')
                {
                    this.Hp -= 3;
                    Console.WriteLine(NormalAttackCharged(curPlayer));
                }
            }
            else
            {
                if (this.type == 's')
                {
                    this.Hp -= 1;
                    Console.WriteLine(BadAttack(curPlayer));
                }
                else if (this.Type == 'a')
                {
                    this.Hp -= 4;
                    Console.WriteLine(GoodAttack(curPlayer));
                }
                else if (this.Type == 'd')
                {
                    this.Hp -= 2;
                    Console.WriteLine(NormalAttack(curPlayer));
                }
            }
        }


        //---Enemy attack ---
        // ---------------- TO DO ----------------
        //need to flesh out the enemy attack and add def to the fight.
        public void EnemyAttack(Player curPlayer)
        {
            int damage = gen.Next(1, 5);
            curPlayer.Hp -= damage;

            Console.WriteLine("{0} hits {1}, about {2} damage hard.", this.Name, 
                curPlayer.Name,damage.ToString());
            Console.WriteLine("-{0}hp!", damage.ToString());
        }
        //----helper methods-----
        public void FightHUD(Player curPlayer)
        {
            //display enemy info
            Console.Clear();
            Console.WriteLine("|-| Name: {0} || HP: {1}/{2} || ---------- |-|", Name, Hp, Maxhp);

            //dispalay the options
            Console.WriteLine("\n");
            Console.WriteLine("Q: Run || W: Normal");
            Console.WriteLine("A: Attack 1 || S: Attack 2 || D: Attack 3");
            Console.WriteLine("--- F: Charge Next Attack ---");

            //display the players
            Console.WriteLine("\n");
            Console.WriteLine("|-| Name: {0} || HP: {1}/{2} || DP: {3}/{4} |-|", curPlayer.Name, curPlayer.Hp, curPlayer.MaxHp, curPlayer.Dp, curPlayer.MaxDp);
        }

        //get the players acttion
        public char GetAction()
        {
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
            } while (key.KeyChar != 'q' || key.KeyChar != 'w' || key.KeyChar != 'a'
            || key.KeyChar != 's' || key.KeyChar != 'd' || key.KeyChar != 'f');

            return key.KeyChar;
        }
        //---Print out the attack results
        public string GoodAttack(Player curPlayer)
        {
            return curPlayer.Name + "'s attack lands hard! \n-4hp!";
        }

        public string BadAttack(Player curPlayer)
        {
            return curPlayer.Name + "'s attack is weak! \n-1hp!";
        }

        public  string NormalAttack(Player curPlayer)
        {
            return curPlayer.Name + "'s attack lands! \n-2hp!";
        }

        public string FailedAttack(Player curPlayer)
        {
            return curPlayer.Name + "tries to do something, but fails... \nnothing happens!";
        }

        //--Charged attack modifer --

        public string GoodAttackCharged(Player curPlayer)
        {
            return curPlayer.Name + "'s charged attack lands super hard!!!\n -10hp!!!";
        }

        public string NormalAttackCharged(Player curPlayer)
        {
            return curPlayer.Name + "'s charged attack lands! \n-3hp!";
        }
    }
}
