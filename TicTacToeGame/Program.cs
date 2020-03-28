using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            WinChecker winChecker = new WinChecker();
            Renderer renderer = new Renderer();
            Player player1 = new Player();
            Player player2 = new Player();
            
            while (!winChecker.isDraw(board) && winChecker.check(board) == State.Undecided)
            {
                renderer.Render(board);
                Position nextMove;
                if (board.nextTurn == State.X)
                {
                    nextMove = player1.getPosition(board);
                }
                else
                {
                    nextMove = player2.getPosition(board);
                }

                if (!board.setState(nextMove, board.nextTurn))
                {
                    Console.WriteLine("This is not legal move.");
                }
            }
            
            renderer.Render(board);
            renderer.renderResult(winChecker.check(board));
            Console.ReadKey();
        }
    }
}