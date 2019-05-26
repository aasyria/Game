using System;

namespace Game
{
    class Program
    {
        // der enum Dirction enthalt möglich bewegung richtungen wird später beim logik von bewegung benutzt
        /**
         *z.B:
         *if (key == 'A'){
         *  player.move(Dirction.Left)
         * }
         */
        public enum Dirction
        {
            Left,
            Right
        }
        static void Main(string[] args)
        {
            //initalziern von der Große des Spielfelds
            int width = 40;
            int height = 40;
            String[,] board = new String[height + 1, width + 1];
            //initalzierung von Player als Objekt 
            Player player = new Player();
            //zeichnen von Spielfelds 
            //aufrufen von DrawBoard Methode
            player.DrawBoard(board);

            // test 
            //bewegen von  der spieler nach links 
            while (true)
            {
                ConsoleKey userInput = Console.ReadKey().Key;
                if (userInput == ConsoleKey.RightArrow)
                {
                    player.Move(Dirction.Right, board);
                }
                else if (userInput == ConsoleKey.LeftArrow)
                {
                    player.Move(Dirction.Left, board);
                }
            }
          
            Console.ReadKey();
        }
    }
}
