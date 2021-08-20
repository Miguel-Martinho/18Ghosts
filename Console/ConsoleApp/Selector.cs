using Ghosts.Common;
using System;

namespace ConsoleApp
{
    public class Selector
    {
        private short row;
        private short column;

        public Selector(short rows, short columns)
        {
            row = rows;
            column = columns;
        }
        //Method responsible for returning a tile that is to be highlighted
        public Tile SelectTile(Tile[,] board, string stringinput,
        Tile currentTile)
        {
            if (stringinput == "left")
            {
                if (currentTile.TilePos.Column == 0)
                    currentTile = board[currentTile.TilePos.Row, column -1];
                else
                currentTile = 
                board[currentTile.TilePos.Row, currentTile.TilePos.Column -1];
            }
            else if (stringinput == "up")
            { 
                if (currentTile.TilePos.Row == 0)
                    currentTile = board[row -1, currentTile.TilePos.Column];   
                else
                currentTile =
                board[currentTile.TilePos.Row -1, currentTile.TilePos.Column]; 
            }
            else if (stringinput == "right")
            {
                if (currentTile.TilePos.Column == column -1)
                    currentTile = board[currentTile.TilePos.Row, 0];
                else
                currentTile = 
                board[currentTile.TilePos.Row, currentTile.TilePos.Column +1];
            }
            else if (stringinput == "down")
            {
                if (currentTile.TilePos.Row == row -1)
                    currentTile = board[0, currentTile.TilePos.Column];
                else
                currentTile = 
                board[currentTile.TilePos.Row +1, currentTile.TilePos.Column];
            }
            return currentTile;
        }
    }
}