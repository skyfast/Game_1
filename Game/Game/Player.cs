using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Player
    {
        private string name;
        private int hp;
        private int dp;
        private int maxHp;
        private int maxDp;

        //tracks charge up in fight
        private bool charge;

        public Player (string pName)
        {
            name = pName;
            hp = 20;
            dp = 20;
            maxDp = 20;
            maxHp = 20;
            charge = false;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Dp
        {
            get { return dp; }
            set { dp = value; }
        }

        public int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }

        public int MaxDp
        {
            get { return maxDp; }
            set { maxDp = value; }
        }

        public bool Charge
        {
            get { return charge; }
            set { charge = value; }
        }

        //this method will make sure status are 
        public void CorrectStats()
        {
            if(this.Hp > this.maxHp)
            {
                this.Hp = this.maxHp;
            }

            if(this.Dp > this.maxDp)
            {
                this.Dp = this.MaxDp;
            }
        }

    }
}
