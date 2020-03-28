using System;

namespace TicTacToeGame
{
    public class Player
    {
        public Position getPosition(Board board)
        {
            int position = Convert.ToInt32(Console.ReadLine());
            Position desiredPosition = this.positionNumber(position);
            return desiredPosition;
        }


        private Position positionNumber(int position)
        {
            switch (position)
            {
                case 1:
                    return new Position(2,0); // Bottom Left
                case 2:
                    return  new Position(2, 1); // Bottom Middle
                case 3:
                    return  new Position(2, 2); // Bottom right
                case 4:
                    return new Position(1,0); // Middle left
                case 5:
                    return new Position(1,1); // Middle middle
                case 6:
                    return new Position(1, 2); // Middle right
                case 7:
                    return new Position(0,0); // Top left
                case 8:
                    return new Position(0, 1); // Top middle
                case 9:
                    return new Position(0, 2); // Top right
                default:
                    return null;
            }
        }
    }
}