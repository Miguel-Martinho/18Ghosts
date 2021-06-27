using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Conway.Common
{
    /// <summary>
    /// Class that represnts the simulation grid
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// Property used to save all the cells
        /// in the simulation
        /// </summary>
        public Cell[,] CellGroup { get; private set;}


        /// <summary>
        /// Constructor for the Grid class
        /// </summary>
        /// <param name="cellGroup">Collection of
        /// cell's in the simulation</param>
        public Grid(Cell[,] cellGroup) 
        {
            CellGroup = cellGroup;
        }
    }
}
