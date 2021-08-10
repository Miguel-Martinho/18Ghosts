
namespace Ghosts.Common
{
    /// <summary>
    /// Represents every cell position in the simulation
    /// </summary>
    public struct Position
    {
        /// <summary>
        /// Property that represents the row value
        /// </summary>
        public short Row { get; private set;}

        /// <summary>
        /// Property that represents the column value
        /// </summary>
        public short Column { get; private set;}

        /// <summary>
        /// Constructor for the Position Class
        /// </summary>
        /// <param name="row">Cell's Row Value</param>
        /// <param name="column">Cell's Column Value</param>
        public Position(short row, short column)
        {
            Row = row;
            Column = column;
        }
        public PortalDirections GetDirection(Position position1, Position position2)
        {
            PortalDirections tempDirection;
            Position result = new Position((short)(position1.Row - position2.Row),
             (short)(position1.Column - position2.Column));

            if(result.Row == 1)
                tempDirection = PortalDirections.Right;           

            else if (result.Row == -1)
                tempDirection = PortalDirections.Left;

            else if(result.Column == 1)
                tempDirection = PortalDirections.Up;
            else
                tempDirection = PortalDirections.Down;

            return tempDirection;
        }
    }
}
