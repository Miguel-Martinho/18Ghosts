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

        public Game()
        {
            board = new Board(5,5);
            game = new GameHandler();
            consoleRenderer = new Renderer(5,5);
            input = new Input(consoleRenderer);
            selector = new Selector(5,5);
        }
        public void GameRun()
        {
            string playerInput = "";
            Tile selectedTile;
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

            //while loop for player to select a Tile
            while (playerInput != "enter")
            {
                playerInput = input.DirectionalInput();

                selectedTile = selector.SelectTile
                (board.TileArray, playerInput, previousTile);

                previousTile = selectedTile;

                consoleRenderer.RenderBoard(board.TileArray, selectedTile);
            }
        }
            //Ta no bloco de notas
    }
}