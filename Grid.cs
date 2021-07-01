using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Conway.Common
{
    /// <summary>
    /// Class that represents the simulation grid
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// Property used to save all the cells
        /// in the simulation
        /// </summary>
        public IList<Cell> CellGroup { get; private set;}

        /// <summary>
        /// Property used to access the maximum
        /// dimensions of the grid's rows
        /// </summary>
        public short MaxRows { get; private set;}

        /// <summary>
        /// Property used to access the maximum
        /// dimensions of the grid's columns
        /// </summary>
        public short MaxColumn { get; private set; }

        /// <summary>
        /// Constructor for the Grid class
        /// </summary>
        /// <param name="cellGroup">Collection of
        /// cell's in the simulation</param>
        public Grid(short maxRow, short maxColumn) 
        {
            MaxRows = maxRow;
            MaxColumn = maxColumn;
        }

        /// <summary>
        /// Method used to place a cell per position
        /// based on the max rows and columns defined
        /// </summary>
        public void GridSetup()
        {
            Cell tempCell;
            for (byte i = 0; i < MaxRows; i++)
            {
                for (byte j = 0; j < MaxColumn; j++)
                {
                    tempCell = new Cell(new Position(i, j));
                    CellGroup.Add(tempCell);
                }
            }
        }

    }
}
