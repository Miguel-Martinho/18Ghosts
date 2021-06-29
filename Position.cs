
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
        public byte Row { get; private set;}

        /// <summary>
        /// Property that represents the column value
        /// </summary>
        public byte Column { get; private set;}

        /// <summary>
        /// Property that represents cell above
        /// </summary>
        public int TopCellPos { get; private set; }

        /// <summary>
        /// Property that represents cell below
        /// </summary>
        public int BotCellPos { get; private set; }

        /// <summary>
        /// Property that represents the left cell
        /// </summary>
        public int LeftCellPos { get; private set; }

        /// <summary>
        /// Property that represents the right cell
        /// </summary>
        public int RightCellPos { get; private set; }


        /// <summary>
        /// Contructor for the Position Class
        /// </summary>
        /// <param name="row">Cell's Row Value</param>
        /// <param name="column">Cell's Column Value</param>
        public Position(byte row, byte column)
        {
            Row = row;
            Column = column;
            TopCellPos = column + 1;
            BotCellPos = column - 1;
            LeftCellPos = row - 1;
            RightCellPos = row + 1;
        }
    }
}
