
namespace MVC_Conway.Common
{
    /// <summary>
    /// Represents every cell in the simulation
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// Prperty used to save the cell's position
        /// </summary>
        public Position CellPos { get; private set;}

        /// <summary>
        /// Property used to save the cell's type
        /// </summary>
        public CellType CellType { get; private set;}

        /// <summary>
        /// Constructor for the Cell Class
        /// </summary>
        /// <param name="position">Cell's position Value</param>
        /// <param name="cellType">Cell's Type Value</param>
        public Cell(Position position, CellType cellType)
        {
            CellPos = position;
            CellType = cellType;
        }

    }
}
