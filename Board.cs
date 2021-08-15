using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    /// <summary>
    /// Class that represents the simulation board
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Property used to access the maximum
        /// dimensions of the board's rows
        /// </summary>
        public short MaxRows { get; private set; }

        /// <summary>
        /// Property used to access the maximum
        /// dimensions of the board's columns
        /// </summary>
        public short MaxColumn { get; private set; }

        public Tile[,] TileArray { get; private set; }


        /// <summary>
        /// Constructor for the board class
        /// </summary>
        /// <param name="cellGroup">Collection of
        /// cell's in the simulation</param>
        public Board(short maxRow, short maxColumn)
        {
            MaxRows = maxRow;
            MaxColumn = maxColumn;
            TileArray = new Tile[MaxRows, MaxColumn];
        }

        public void BoardTilesSetup()
        {
            
            for (short i = 0; i < MaxRows; i++)
            {
                for (short j = 0; j < MaxColumn; j++)
                    {
                        if (i == 0 && j == 0 || i == 0 && j == 3 || i == 2 && j == 1
                        || i == 2 && j == 3 || i == 3 && j == 0 || i == 4 && j == 3)
                    {
                        TileArray[i,j] = new CarpetTile(new Position(i,j), Color.Blue);
                    }
    
                    else if(i == 0 && j == 1 || i == 0 && j == 4 || i == 2 && j == 0
                    || i == 2 && j == 2 || i == 3 && j == 4 || i == 4 && j == 1)
                    {
                        TileArray[i,j] = new CarpetTile(new Position(i,j), Color.Red);
                    }
    
                    else if(i == 1 && j == 0 || i == 1 && j == 2 || i == 1 && j == 4
                    || i == 3 && j == 2 || i == 4 && j == 0 || i == 4 && j == 4)
                    {
                        TileArray[i,j] = new CarpetTile(new Position(i,j), Color.Yellow);
                    }
    
                    else if(i == 1 && j == 1 || i == 3 && j == 1 || i == 1 && j == 3
                    || i == 3 && j == 3)
                    {
                        TileArray[i,j] = new MirrorTile(new Position(i,j));
                    }
                    else if (i == 0 && j == 2)
                    {
                        TileArray[i,j] = new PortalTile(new Position(i,j),
                        Color.Red, PortalDirections.Up);
                    }
                    else if (i == 2 && j == 4)
                    {
                        TileArray[i,j] = new PortalTile(new Position(i,j),
                        Color.Yellow, PortalDirections.Right);
                    }
                    else if (i == 4 && j == 2)
                    {
                        TileArray[i,j] = new PortalTile(new Position(i,j),
                        Color.Blue, PortalDirections.Down);
                    }

                }

            }
            

        }
    }
}
