using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class PortalTile : Tile
    {
        public override Position TilePos { get;}

        public override TileType TileType { get;}

        public override Color Color { get;}

        public override PortalDirections Direction { get; protected set; }

        public PortalTile(Position pos, Color color,
            PortalDirections dir)
        {
            TileType = TileType.Portal;
            Color = color;
            Direction = dir;
        }

        public void ChangeDirection()
        {
            if (Direction == PortalDirections.Left)
            {
                Direction = PortalDirections.Up;
            }
            else
                Direction += 1;
        }


    }
}
