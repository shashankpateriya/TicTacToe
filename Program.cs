using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] createBoard;
            Game obj = new Game();
            createBoard=obj.Board();
            //obj.ChoosePlayer();
            obj.ShowBoard(createBoard);
        }
    }
}