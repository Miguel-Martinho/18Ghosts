
using System;

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
        public Position CellPos { get; private set; }

        /// <summary>
        /// Property used to save the cell's type
        /// </summary>
        public CellType CellType { get; set; }

        private Random rng;
        /// <summary>
        /// Constructor for the Cell Class
        /// </summary>
        /// <param name="position">Cell's position Value</param>
        /// <param name="cellType">Cell's Type Value</param>
        public Cell(Position position)
        {
            CellPos = position;
            CellType = TypeGenerator();
        }

        /// <summary>
        /// Method used to randomly assign a CellType
        /// to a cell using a random number
        /// </summary>
        /// <returns></returns>
        public CellType TypeGenerator()
        {
            int cellTypeValue;
            rng = new Random();
            cellTypeValue = rng.Next(1, 3);

            switch (cellTypeValue)
            {
                case 1:
                    return CellType.Rock;
                case 2:
                    return CellType.Paper;

                case 3:
                    return CellType.Scissors;

                default:
                    return CellType.Empty;
            }

        }

    }
}
