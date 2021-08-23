using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class GameHandler
    {
        public IList<Ghost> P1Ghosts { get; private set; }
        public IList<Ghost> P2Ghosts { get; private set; }
        public IList<Ghost> DungeonGhosts { get; private set; }
        public IList<Ghost> EscapedGhosts { get; private set; }
        private byte player1wincount;
        private byte player2wincount;
        public byte CurrentPlayer { get; private set; }

        public GameHandler()
        {
            P1Ghosts = new List<Ghost>();
            P2Ghosts = new List<Ghost>();
            DungeonGhosts = new List<Ghost>();
            EscapedGhosts = new List<Ghost>();
            CurrentPlayer = 1;
            player1wincount = 0;
            player2wincount = 0;
        }
        public bool PlaceGhost(Tile tile)
        {
            Ghost tempGhost;
            byte counter = 0;

            if (tile.TileType == TileType.Portal ||
                tile.TileType == TileType.Mirror || tile.IsEmpty == false)
                return false;

            else if(checkGhostList(tile) == false)
                return false;

            else
            {
                tempGhost = new Ghost(tile as CarpetTile, CurrentPlayer);
                tile.ChangeState();
                tile.AssignGhostToTile(tempGhost);

                if (CurrentPlayer == 1)
                    P1Ghosts.Add(tempGhost);
                else 
                    P2Ghosts.Add(tempGhost);
            }
            return true;
        }

        public void ChangeCurrentPlayer()
        {
            if (CurrentPlayer == 1) 
                CurrentPlayer = 2;
            else
                CurrentPlayer = 1;
        }

        public void ReleaseGhost(Ghost ghost)
        {
            if (ghost.Player == 1)
            {
                P1Ghosts.Remove(ghost);
                player1wincount++;
            }
            else
            {
                P2Ghosts.Remove(ghost);
                player2wincount++;
            }   
            Wincheck();
            /*EscapedGhosts.Add(ghost); //WHY DO WE NEED THIS ?
            if (ghost.Player == 1)
                player1wincount++;
            else
                player2wincount++;
            */
        }

        public void KillGhost(Ghost ghost)
        {
            if (ghost.Player == 1)
                P1Ghosts.Remove(ghost);
            else
                P2Ghosts.Remove(ghost);
            DungeonGhosts.Add(ghost);
        }

        public bool RespawnGhost(Ghost ghost)
        {
            if (DungeonGhosts.Count == 0)
                return false;
            else
            {
                DungeonGhosts.Remove(ghost);
                ghost.ChangeOwner();
                if (ghost.Player == 1)
                    P1Ghosts.Add(ghost);
                else
                    P2Ghosts.Add(ghost);
                return true;
            }
        }

        public void Fight(Ghost ghost1, Ghost ghost2)
        {
            Tile temptile;

            if (ghost1.Color == Color.Blue && ghost2.Color == Color.Yellow)
            {
                temptile = ghost2.CurrentTile;
                KillGhost(ghost2);
                ghost1.Movement(temptile);
            }
            else if (ghost1.Color == Color.Yellow && ghost2.Color == Color.Red)
            {
                temptile = ghost2.CurrentTile;
                KillGhost(ghost2);
                ghost1.Movement(temptile);
            }
            else if (ghost1.Color == Color.Red && ghost2.Color == Color.Blue)
            {
                temptile = ghost2.CurrentTile;
                KillGhost(ghost2);
                ghost1.Movement(temptile);
            }
            else
            {
                temptile = ghost1.CurrentTile;
                KillGhost(ghost1);
                ghost2.Movement(ghost1.CurrentTile);
            }
        }

        public byte Wincheck()
        {
            if (player1wincount == 3)
            {
                return 1;
            }
            else if (player2wincount == 3)
            {
                return 2;
            }
            else
                return 0;
        }

        private bool checkGhostList(Tile tile)
        {
            byte counter = 0;
            if (CurrentPlayer == 1)
            {
                foreach (Ghost ghost in P1Ghosts)
                    if (ghost.Color == tile.Color)
                        counter++;
                    if (counter == 3)
                        return false;
                    else
                        return true;
            }
            else
            {
                foreach (Ghost ghost in P2Ghosts)
                    if (ghost.Color == tile.Color)
                        counter++;
                    if (counter == 3)
                        return false;
                    else
                        return true;
            }
        }
    }
}
