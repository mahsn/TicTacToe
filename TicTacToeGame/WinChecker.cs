namespace TicTacToeGame
{
    public class WinChecker
    {
        public State check(Board board)
        {
            
            return State.Undecided;
        }

        private bool checkForWin(Board board, State player)
        {
            for (int row = 0; row < 3; row++)
            {
                if (this.areAll(board, new Position[]
                    {new Position(row,0), new Position(row, 1), new Position(row, 2), },player ))
                {
                    return true;
                }
            }

            for (int column = 0; column < 3; column++)
            {
                if (this.areAll(board, new Position[]
                    {new Position(column, 0), new Position(column, 1), new Position(column, 2), }, player))
                {
                    return true;
                }
            }

            if (this.areAll(board, new Position[]
                {new Position(0,0), new Position(1,1), new Position(2,2),  }, player))
            {
                return true;
            }

            if (this.areAll(board, new Position[]
                {new Position(2, 0), new Position(1, 1), new Position(0, 2), }, player))
            {
                return true;
            }
            
            return false;
        }

        private bool areAll(Board board, Position[] positions, State state)
        {
            foreach (Position position in positions)
            {
                if (board.getState(position) != state) return false;
            }

            return true;
        }

        public bool isDraw(Board board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (board.getState(new Position(row, column)) == State.Undecided)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}