namespace Common
{
    public interface ITile
    {
        /// <summary>
        /// Property used to save the Tile's position
        /// </summary>
        public Position TilePos { get; private set; }

        /// <summary>
        /// Property used to save the Tile's type
        /// </summary>
        public TileType TileType { get; set; }
    }
}