using Ghosts.Common;

namespace Ghosts.Common
{
    public abstract class Tile
    {
        /// <summary>
        /// Property used to save the Tile's position
        /// </summary>
        public abstract Position TilePos { get;}

        /// <summary>
        /// Property used to save the Tile's type
        /// </summary>
        public abstract TileType TileType { get;}


        /// <summary>
        /// Properties only implemented by specific tiles
        /// </summary>
        /// <value></value>
        public virtual Color Color { get;}
        public virtual bool IsEmpty { get; protected set;}
        public virtual PortalDirections Direction { get; protected set;}
        public virtual Ghost Ghost { get; protected set;}

    }
}