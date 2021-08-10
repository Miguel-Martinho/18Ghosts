namespace Ghosts.Common
{
    public class Ghost
    {
        public Position Pos { get; set;}

        public Color Color {get; private set;}

        public byte Player { get; private set;}

        public Ghost(Position pos, 
            Color col, byte player)
        {
            Pos = pos;
            Color = col;
            Player = player;
        }

        /// <summary>
        /// Method used to move the ghost from its
        /// current position into an empty tile
        /// </summary>
        public void Movement(ITile tile)
        {
            
            if(tile.TileType == TileType.Portal)
            {
                GetMoveDirection();
            }
            this.Pos = pos;
        }

        /// <summary>
        ///  Method used to make two
        ///  Ghosts to fight till the death
        /// </summary>
        public void Fight()
        {


        }

        private void GetMoveDirection()
        {

        }

    }
}