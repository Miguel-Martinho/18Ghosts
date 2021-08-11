﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class GameHandler
    {
        public IList<Ghost> Ghosts {get; private set;}
        public IList<Ghost> DungeonGhosts { get; private set; }
        public IList<Ghost> EscapedGhosts { get; private set; }
        public byte player1wincount;
        public byte player2wincount;
        public byte CurrentPlayer { get; private set; }

        public GameHandler()
        {
            Ghosts = new List<Ghost>();
            DungeonGhosts = new List<Ghost>();
            EscapedGhosts = new List<Ghost>();
            CurrentPlayer = 1;
            player1wincount = 0;
            player2wincount = 0;
        }
        public void PlaceGhost(Tile tile)
        {
            Ghost tempGhost; 
            tempGhost = new Ghost (tile as CarpetTile, CurrentPlayer);
            Ghosts.Add(tempGhost);
        }

        public void ChangeCurrentPlayer()
        {
            if (CurrentPlayer == 1) CurrentPlayer = 2;
            else
                CurrentPlayer = 1;
        }

        public void ReleaseGhost(Ghost ghost)
        {
            Ghosts.Remove(ghost);
            EscapedGhosts.Add(ghost);
            if (ghost.Player == 1)
                player1wincount++;
            else 
                player2wincount++;
            Wincheck();
        }

        public void KillGhost(Ghost ghost)
        {
            Ghosts.Remove(ghost);
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
                Ghosts.Add(ghost);
                return true;
            }
        }

        public void Fight(Ghost ghost1, Ghost ghost2)
        {
            if (ghost1.Color == Color.Blue && ghost2.Color == Color.Yellow)
            {
                ghost1.Movement(ghost2.CurrentTile);
                KillGhost(ghost2);
            }
            else if (ghost1.Color == Color.Yellow && ghost2.Color == Color.Red)
            {
                ghost1.Movement(ghost2.CurrentTile);
                KillGhost(ghost2);
            }
            else if (ghost1.Color == Color.Red && ghost2.Color == Color.Blue)
            {
                ghost1.Movement(ghost2.CurrentTile);
                KillGhost(ghost2);
            }
            else
            {
                ghost2.Movement(ghost1.CurrentTile);
                KillGhost(ghost1);
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
    }
}
