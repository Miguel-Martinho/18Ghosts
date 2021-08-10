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

        public IList<Position> PositionList { get; private set; }

        public IList<Tile> TileList { get; private set; }


        /// <summary>
        /// Constructor for the board class
        /// </summary>
        /// <param name="cellGroup">Collection of
        /// cell's in the simulation</param>
        public Board(short maxRow, short maxColumn)
        {
            MaxRows = maxRow;
            MaxColumn = maxColumn;
        }

        /// <summary>
        /// Method used to place a cell per position
        /// based on the max rows and columns defined
        /// </summary>
        public void BoardPositionsSetup()
        {
            Position tempPos;

            for (byte i = 0; i < MaxRows; i++)
            {
                for (byte j = 0; j < MaxColumn; j++)
                {
                    tempPos = new Position(i, j);
                    PositionList.Add(tempPos);
                }
            }
        }

        public void BoardTilesSetup()
        {
            Tile tempTile;

            for (int i = 0; i < PositionList.Count; i++)
            {

                if (i == 0 || i == 3 || i == 11 ||
                    i == 13 || i == 15 || i == 23)
                {
                    tempTile = new CarpetTile(PositionList[i], Color.Blue);
                    TileList.Add(tempTile);
                }

                else if (i == 1 || i == 4 || i == 10 ||
                    i == 12 || i == 19 || i == 21)
                {
                    tempTile = new CarpetTile(PositionList[i], Color.Red);
                    TileList.Add(tempTile);
                }

                else if (i == 5 || i == 7 || i == 9 ||
                    i == 17 || i == 20 || i == 24)
                {
                    tempTile = new CarpetTile(PositionList[i], Color.Yellow);
                    TileList.Add(tempTile);
                }

                else if (i == 6 || i == 8 || i == 16 ||
                    i == 18)
                {
                    tempTile = new MirrorTile(PositionList[i]);
                    TileList.Add(tempTile);
                }

                else if (i == 6 || i == 8 || i == 16 ||
                    i == 18)
                {
                    tempTile = new MirrorTile(PositionList[i]);
                    TileList.Add(tempTile);
                }

                else if (i == 2)
                {
                    tempTile = new PortalTile(PositionList[i],
                        Color.Red, PortalDirections.Up);
                    TileList.Add(tempTile);
                }
            }
        }
    }
}
