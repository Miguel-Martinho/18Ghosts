using System;
using Ghosts.Common;

namespace ConsoleApp
{
    public class Game
    {
        private Board board;
        private GameHandler game;

        public Gameloop()
        {
            board = new Board(5,5);
            game = new GameHandler();
            //new input instance
            //new renderer instance
        }
        public GameRun()
        {
            board.BoardTilesSetup();
            game = new GameHandler();

            //this is here because at the start player 1
            //plays once and then player 2 plays twice

            //selectedtile = Selector();    
            //game.PlaceGhost(selected tile);
            game.ChangeCurrentPlayer();
            //selectedtile = Selector();    
            //game.PlaceGhost(selected tile);
            //selectedtile = Selector();    
            //game.PlaceGhost(selected tile);
            game.ChangeCurrentPlayer();

            while (game.Ghosts.Count < 15)
            {
                //selectedtile = Selector();
                //game.PlaceGhost(selected tile);
                game.ChangeCurrentPlayer();

            }
            while(game.Wincheck() == 0)
            {
                Console.ReadLine();
                //Class input chose revive or ghost
                //if (ghost)
                //select ghost
                //selectedghost = Selector();
                //select a tile
                //selectedtile = Selector();
                //if tile is not empty
                //game handler grabs that tiles ghost
                game.Fight(selectedghost, selectedtile.ghost);
                    //else
                    //selectedghost.Movement(selectedtile);
                //else if (revive)
                game.RespawnGhost();
                //else (print "dungeon is empty")

            }

        }
        
    }
}