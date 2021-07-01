
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

        public short MaxRows {get;}
        public short MaxColumns {get;}


        /// <summary>
        /// Constructor for the Position Class
        /// </summary>
        /// <param name="row">Cell's Row Value</param>
        /// <param name="column">Cell's Column Value</param>
        public Position(short row, short column, short maxRows, short maxColumns)
        {
            Row = row;
            Column = column;
            MaxRows = maxRows;
            MaxColumns = maxColumns;
            if(column + 1 > MaxColumns)
               RightCellPos = 0;
            else
                RightCellPos = (short)(column + 1);

            if(column - 1 < 0)
                LeftCellPos = MaxColumns;
            else
                LeftCellPos = (short)(column - 1);  

            if(row + 1 > MaxRows)
                TopCellPos = 0;
            else
                TopCellPos = (short)(row + 1);

            if(row - 1 > 0)
                BotCellPos = MaxRows;
            else
                BotCellPos = (short)(row - 1);
        }
    }
}
