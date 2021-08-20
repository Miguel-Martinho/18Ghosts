using System;
using Ghosts.Common;

namespace ConsoleApp
{
    public class Game
    {
        private Board board;
        private GameHandler game;
        private Input input;
        private Renderer consoleRenderer;
        private Selector selector;
        private Tile previousTile;
        private Tile selectedTile;
        private Tile toMove;
        private bool placingphase;
        private bool playingphase;

        public Game()
        {
            board = new Board(5,5);
            game = new GameHandler();
            consoleRenderer = new Renderer(5,5);
            input = new Input(consoleRenderer);
            selector = new Selector(5,5);
            placingphase = true;
        }
        public void GameRun()
        {
            string playerInput = "";
            //Prints the Title Card
            consoleRenderer.PrintTitleScreen();
            input.TitleScreenInput();
            do
            {
                // Gets user Input
                playerInput = input.MainMenuInput();
                if (playerInput == "1") break;

                //Breaks the loop and quits the game
                if (playerInput == "4") break;

            } while (true);
            //sets up the board for the start of the game
            board.BoardTilesSetup();
            previousTile = board.TileArray[0,0];
            consoleRenderer.RenderBoard(board.TileArray, previousTile);

            //Lots of repeateded code, very spaghet
            //TODO: FIX SPAGHET
            while(placingphase ==  true)
            {
                while (playerInput != "enter")
                {
                    playerInput = input.DirectionalInput();

                    selectedTile = selector.SelectTile
                    (board.TileArray, playerInput, previousTile);

                    previousTile = selectedTile;

                    consoleRenderer.RenderBoard(board.TileArray, selectedTile);
                }
                playerInput = "";
                game.PlaceGhost(selectedTile);
                game.ChangeCurrentPlayer();
            }

            while (playingphase == true)
            {
                while (playerInput != "enter")
                {
                    playerInput = input.DirectionalInput();

                    selectedTile = selector.SelectTile
                    (board.TileArray, playerInput, previousTile);

                    previousTile = selectedTile;

                    consoleRenderer.RenderBoard(board.TileArray, selectedTile);
                }
                playerInput = "";
                while (playerInput != "enter")
                {
                    playerInput = input.DirectionalInput();

                    toMove = selector.SelectTile
                    (board.TileArray, playerInput, previousTile);

                    previousTile = toMove;

                    consoleRenderer.RenderBoard(board.TileArray, selectedTile);
                }
                if (toMove.IsEmpty == true)
                    selectedTile.Ghost.Movement(toMove);
                else
                    game.Fight(selectedTile.Ghost, toMove.Ghost);
            }
            //while loop for player to select a Tile
            
        }
            //Ta no bloco de notas
    }
}