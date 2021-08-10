using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class CarpetTile : Tile
    {
        public override Position TilePos { get;}

        public override TileType TileType { get;}

        public override Color Color { get;}

        public override bool IsEmpty { get; set; }

        public CarpetTile(Position pos, Color color)
        {
            TileType = TileType.Carpet;
            Color = color;
            IsEmpty = true;
        }

        public void ChangeState() => IsEmpty = false ? true : false;


    }
}
