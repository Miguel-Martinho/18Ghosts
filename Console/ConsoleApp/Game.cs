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

        public Game()
        {
            board = new Board(5,5);
            game = new GameHandler();
            consoleRenderer = new Renderer(5,5);
            input = new Input(consoleRenderer);
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
            board.BoardTilesSetup();
            consoleRenderer.RenderBoard(board.TileArray);

        }
            //Ta no bloco de notas

        }
        
    }