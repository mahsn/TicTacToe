namespace TicTacToeGame
{
    public class Board
    {
        private State[,] states;
        public State nextTurn { get; private set; }


        public Board()
        {
            states = new State[3,3];
            nextTurn = State.X;
        }


        public State getState(Position position)
        {
            return states[position.getRow(), position.getColumn()];
        }

        public bool setState(Position position, State newState)
        {
            if (newState != this.nextTurn) return false;
            if (states[position.getRow(), position.getColumn()] != State.Undecided) return false;
            states[position.getRow(), position.getColumn()] = newState;
            this.switchNextTurn();    
            return true;
        }

        private State switchNextTurn()
        {
           return (this.nextTurn == State.X) ? (this.nextTurn = State.O) : (this.nextTurn = State.X);
        }
    }
}