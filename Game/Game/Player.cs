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

        public Player (string pName)
        {
            name = pName;
            hp = 20;
            dp = 20;
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
    }
}
