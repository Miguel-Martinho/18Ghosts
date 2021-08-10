using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class CarpetTile : ITile
    {
        public Position TilePos { get; private set;}

        public TileType TileType { get; private set; }

        public Color Color { get; private set; }

        public bool IsEmpty { get; private set; }

        public CarpetTile(Position pos, Color color)
        {
            TileType = TileType.Carpet;
            Color = color;
            IsEmpty = true;
        }

        public void ChangeState() => IsEmpty = false ? true : false;


    }
}
