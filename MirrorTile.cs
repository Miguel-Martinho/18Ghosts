using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class MirrorTile : Tile
    {
        public override Position TilePos { get;}

        public override TileType TileType { get;}

        public override bool IsEmpty { get; protected set;}

        public override Ghost Ghost { get; protected set;}

        public MirrorTile(Position pos)
        {
            TilePos = pos;
            TileType = TileType.Mirror;
            IsEmpty = true;
        }
        public override void AssignGhostToTile(Ghost ghost)
        {
            Ghost = ghost;
        }

        public override void ChangeState() => IsEmpty = false ? true : false;
    }
}
