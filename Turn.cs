using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class Turn
    {
        public IList<Ghost> Ghosts {get; private set;}

        public byte CurrentPlayer { get; private set; }

        public void PlaceGhost(Tile tile, byte player)
        {
            Ghost tempGhost; 
            if (tile.TileType != TileType.Carpet)
                throw new NotImplementedException();
            else
                tempGhost = new Ghost (tile as CarpetTile, player);
        }

        public void ChangeCurrentPlayer()
        {
            if (CurrentPlayer == 1) CurrentPlayer = 2;
            else
                CurrentPlayer = 1;
        }
    }
}
