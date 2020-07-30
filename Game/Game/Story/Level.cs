using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Story
{
    
    public class Level
    {
        //CONST Map markers
        const char EMPTY = '.';
        
        private const int WIDTH = 10;
        private int length;
        private Char[,] board;
        private int levelNum;

        public Level(int num)
        {
            levelNum = num;
            length = 15 + ((num - 1) * 5); // the level gets biger each time
            board = new char[length, WIDTH];
            FillBoard();

        }

        public void FillBoard()
        {
            for(int i = 0; i < length; i++)
            {
                for(int x = 0; x < WIDTH; x++)
                {
                    board[x,i] = EMPTY;
                }
            }
        }

        public void DisplayBoard(Player curPlayer)
        {
            Console.Clear();
            for(int i = 0; i < length; i++)
            {
                Console.Write("| ");
                for(int x = 0; x < WIDTH; x++)
                {
                    Console.Write("{0} ", board[x,i]);
                }
                Console.Write("| \n");
            }
            Console.WriteLine("|-| Name: {0}  || HP: {1} || DP: {2} |-|", curPlayer.Name, curPlayer.Hp, curPlayer.Dp);
        }
    }
}
