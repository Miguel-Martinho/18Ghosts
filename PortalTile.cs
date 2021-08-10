using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class PortalTile : ITile
    {
        public Position TilePos { get; private set; }

        public TileType TileType { get; private set; }

        public Color Color { get; private set; }

        public PortalDirections Direction { get; private set; }

        public PortalTile(Position pos, Color color,
            PortalDirections dir)
        {
            TileType = TileType.Carpet;
            Color = color;
            Direction = dir;
        }

        public void ChangeDirection()
        {
            if (this.Direction == PortalDirections.Left)
            {
                this.Direction = PortalDirections.Up;
            }
            else
                this.Direction += 1;
        }


    }
}
