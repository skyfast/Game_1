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
        const char PLAYERSYM = '@';
        const char ITEM = '?';
        const char EXIT = 'X';

        //random gen
        Random gen = new Random();

        private const int WIDTH = 10;
        private int length;
        private Char[,] board;
        private int levelNum;

        public Level(int num)
        {
            levelNum = num;
            length = 10 + ((num - 1) * 5); // caclulate the langht based on the lvl num
            board = new char[length, WIDTH];
            FillBoard();

        }

        //fills the board
        public void FillBoard()
        {
            //first just set up the board
            for(int i = 0; i < length; i++)
            {
                for(int x = 0; x < WIDTH; x++)
                {
                    board[i,x] = EMPTY;
                }
            }

            //add player
            board[length-1, 0] = PLAYERSYM;

            //add exit
            board[0, WIDTH -1] = EXIT;

            //five items + 2 for each lvl
            int itemNum = 5 + (levelNum - 1 * 2);

            //I am not sure why but need to be <= to get all five
            //im starting at 0 so it should work but it does not so rip
            for(int i = 0; i <= itemNum; i++)
            {
                int x, y;

                do
                {
                    x = gen.Next(0, WIDTH);
                    y = gen.Next(0, length);
                } while (board[y, x] != EMPTY);
                board[y, x] = ITEM;
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
                    Console.Write("{0} ", board[i,x]);
                }
                Console.Write("| \n");
            }
            Console.WriteLine("|-| Name: {0} || HP: {1} || DP: {2} |-|", curPlayer.Name, curPlayer.Hp, curPlayer.Dp);
        }
    }
}
