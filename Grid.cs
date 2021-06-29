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
        public ICollection<Cell> CellGroup { get; private set;}

        /// <summary>
        /// Property used to acess the maximum
        /// dimensions of the grid's rows
        /// </summary>
        public byte MaxRows { get; private set;}

        /// <summary>
        /// Property used to acess the maximum
        /// dimensions of the grid's collumns
        /// </summary>
        public byte MaxColumn { get; private set; }



        /// <summary>
        /// Constructor for the Grid class
        /// </summary>
        /// <param name="cellGroup">Collection of
        /// cell's in the simulation</param>
        public Grid(byte maxRow, byte maxCollumn) 
        {
           
            MaxRows = maxRow;
            MaxColumn = maxCollumn;
        }

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
