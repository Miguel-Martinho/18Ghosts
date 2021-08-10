using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class Turn
    {
        public IList<Ghost> Ghosts {get; private set;}
        public IList<Ghost> DungeonGhosts { get; private set; }
        public IList<Ghost> EscapedGhosts { get; private set; }

        public byte CurrentPlayer { get; private set; }

        public Turn()
        {
            Ghosts = new List<Ghost>();
            DungeonGhosts = new List<Ghost>();
            EscapedGhosts = new List<Ghost>();
            CurrentPlayer = 1;
        }
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

        public void ReleaseGhost(Ghost ghost)
        {
            Ghosts.Remove(ghost);
            EscapedGhosts.Add(ghost);
        }

        public void KillGhost(Ghost ghost)
        {
            Ghosts.Remove(ghost);
            DungeonGhosts.Add(ghost);
        }

        public void RespawnGhost(Ghost ghost)
        {
            DungeonGhosts.Remove(ghost);
            ghost.ChangeOwner();
            Ghosts.Add(ghost);
        }
    }
}
