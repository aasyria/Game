using System;


/*
 * diese Klasse für die Implemntierung von Player und Inthaltet :
 * der zeichnen von der  Board wo der Spieler darstehen wird .
 * der jeztige Position von der Spieler
 * schiessen
 * und bewegen 
 * **/
namespace Game
{
    class Player
    {

        private int width = 0;
        private int height = 0;
        private int s = 0;
        //zeichnen von Board des spiel 
        public void DrawBoard(String[,] board)
        {
            width = board.GetUpperBound(0);
            height = board.GetUpperBound(1);
            Console.SetWindowSize(width + 5, height + 5);
            for (int i = 0; i < board.GetUpperBound(0); i++)
            {
                for (int j = 0; j < board.GetUpperBound(1); j++)
                {
                    if (i == 0 || j == 0 || i == board.GetUpperBound(0) - 1 || j == board.GetUpperBound(1) - 1)
                    {
                        board[i, j] = "#";
                    }
                    else
                    {
                        board[i, j] = " ";
                    }
                    board = DrawPlayer(board, s);
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }

        }
        private void getPlayerPostion()
        {

        }
        // zeichnen von spieler 
        public String[,] DrawPlayer(String[,] board,int i = 0)
        {
            board[board.GetUpperBound(0) - 2, (board.GetUpperBound(1) / 2) - 1 + i] = "@";
            board[board.GetUpperBound(0) - 2, (board.GetUpperBound(1) / 2)+ i] = "@";
            board[board.GetUpperBound(0) - 2, (board.GetUpperBound(1) / 2) +1 + i] = "@";
            board[board.GetUpperBound(0) - 3, (board.GetUpperBound(1) / 2)+ i] = "@";
            return board;
        }
        //bewegen 
        public void Move(Program.Dirction dirction, string[,] board)
        {
            //wenn die Dirction Left wird der Player auf 4 plätze links verschoben
            if (dirction == Program.Dirction.Left)
            {
                Console.Clear();
                    s = s + (-3);
                    DrawBoard(board);
             

            }
            if(dirction == Program.Dirction.Right)
            {
                Console.Clear();
                    s = s + 3;
                    DrawBoard(board);
                
               
            }
          

        }
    }
}
