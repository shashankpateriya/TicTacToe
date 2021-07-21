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
        public char ChoosePlayer()
        {
            char[] choice = new char[] { 'X', 'O' };
            Console.WriteLine("Choose X or O ");
            char playerChoice = char.Parse(Console.ReadLine());
            if (playerChoice == choice[0])
            {
                playerChoice = choice[0];
            }
            else
            {
                playerChoice = choice[1];
            }
            return playerChoice;
        }
        public void ShowBoard(char[] createBoard)
        {
            
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[1], createBoard[2], createBoard[3]);
            Console.WriteLine("_____|_____|_____ ");           
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[4], createBoard[5], createBoard[6]);
            Console.WriteLine("_____|_____|_____ ");           
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[7], createBoard[8], createBoard[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}