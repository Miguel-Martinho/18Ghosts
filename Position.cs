
namespace MVC_Conway.Common
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
        /// Property that represents cell above
        /// </summary>
        public short TopCellPos { get; private set; }

        /// <summary>
        /// Property that represents cell below
        /// </summary>
        public short BotCellPos { get; private set; }

        /// <summary>
        /// Property that represents the left cell
        /// </summary>
        public short LeftCellPos { get; private set; }

        /// <summary>
        /// Property that represents the right cell
        /// </summary>
        public short RightCellPos { get; private set; }


        /// <summary>
        /// Constructor for the Position Class
        /// </summary>
        /// <param name="row">Cell's Row Value</param>
        /// <param name="column">Cell's Column Value</param>
        public Position(short row, short column)
        {
            Row = row;
            Column = column;
            TopCellPos = (short)(column + 1);
            BotCellPos = (short)(column - 1);
            LeftCellPos = (short)(row - 1);
            RightCellPos = (short)(row + 1);
        }
    }
}
