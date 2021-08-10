using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class Turn
    {
        public IList<Ghost> Player1Ghosts { get; private set; }

        public IList<Ghost> Player2Ghosts { get; private set; }

        public short CurrentPlayer { get; private set; }

        public void PlaceGhost(ITile tile, short player)
        {
            if (tile.TileType != TileType.Carpet)
                throw new NotImplementedException
            else
            Ghost tempGhost = new Ghost (tile.TilePos, tile.TileType. player)
        }

        public void ChangeCurrentPlayer()
        {
            if (CurrentPlayer == 1) CurrentPlayer = 2;
            else
                CurrentPlayer = 1;
        }
            new
        SelectGhost
            Move

            Fight

        RespawnGhost
    }
}
