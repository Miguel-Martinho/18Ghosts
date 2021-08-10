using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class MirrorTile : ITile
    {
        public Position TilePos { get; private set; }

        public TileType TileType { get; private set; }


        public bool IsEmpty { get; private set; }

        public MirrorTile(Position pos, Color color)
        {
            TileType = TileType.Carpet;
            IsEmpty = true;
        }

        public void ChangeState() => IsEmpty = false ? true : false;
    }
}
