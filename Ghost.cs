namespace Ghosts.Common
{
    public class Ghost
    {
        public Position Pos { get; set;}

        public Color Color {get; private set;}

        public byte Player { get; private set;}

        private Position temppos;

        public Ghost(CarpetTile tile,
         byte player)
        {
            temppos = new Position();
            Pos = tile.TilePos;
            Color = tile.Color;
            Player = player;
        }

        /// <summary>
        /// Method used to move the ghost from its
        /// current position into an empty tile
        /// </summary>
        public void Movement(Tile tile)
        {
            
            if(tile.TileType == TileType.Portal)
            {
                if (tile.Direction == Pos.GetDirection(Pos, tile.TilePos) -2)
                {
                    //Ghost escape
                }
                else 
                {
                    //dont move there
                }
            }
        }

        /// <summary>
        ///  Method used to make two
        ///  Ghosts to fight till the death
        /// </summary>
        public void Fight()
        {


        }
    }
}