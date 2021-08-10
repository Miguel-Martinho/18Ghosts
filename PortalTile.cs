using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class PortalTile
    {
        public Position TilePos { get; private set; }

        public TileType TileType { get; private set; }

        public Color Color { get; private set; }

        public Direction 1234;

        public PortalTile(Position pos, Color color)
        {
            TileType = TileType.Carpet;
            Color = color;

        }


    }
}
