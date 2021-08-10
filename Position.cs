
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

        public short MaxRows {get; private set;}
        public short MaxColumns {get; private set;}


        /// <summary>
        /// Constructor for the Position Class
        /// </summary>
        /// <param name="row">Cell's Row Value</param>
        /// <param name="column">Cell's Column Value</param>
        public Position(short row, short column)
        {
            Row = row;
            Column = column;
            MaxRows = 5;
            MaxColumns = 5;
            
        }
    }
}
