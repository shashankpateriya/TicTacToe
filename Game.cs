using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Game
    {
        public char[] Board()
        {
            char[] createBoard = new char[10];
            for (int i = 1; i < createBoard.Length; i++)
            {
                createBoard[i] = ' ';
            }
            return createBoard;
        }
    }
}