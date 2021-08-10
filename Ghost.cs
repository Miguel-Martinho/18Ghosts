namespace Ghosts.Common
{
    public class Ghost
    {
        public Position Pos { get; set;}

        public Color Color {get; private set;}

        public byte Player { get; private set;}

        public Ghost(CarpetTile tile,
         byte player)
        {
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
            Pos = tile.TilePos;
            /*if(tile.TileType == TileType.Portal)
            {
                if (tile.Direction == Pos.GetDirection(Pos, tile.TilePos) -2)
                {
                    //Ghost escape
                }
                else 
                {
                    //dont move there
                }
            }*/
/*
            if (tile.TileType == TileType.Carpet && tile.IsEmpty == true)
            {
                Pos = tile.TilePos;
            }*/
        }

        /// <summary>
        ///  Method used to make two
        ///  Ghosts to fight till the death
        /// </summary>
        public byte Fight(Tile tile)
        {
            Movement(tile);

        }

        public void ChangeOwner()
        {
            if (Player == 1) Player = 2;
            else
                Player = 1;
        }
    }
}