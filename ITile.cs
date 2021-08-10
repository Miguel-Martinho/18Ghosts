using Ghosts.Common;

namespace Ghosts.Common
{
    public interface ITile
    {
        /// <summary>
        /// Property used to save the Tile's position
        /// </summary>
        Position TilePos { get;}

        /// <summary>
        /// Property used to save the Tile's type
        /// </summary>
        TileType TileType { get;}
    }
}