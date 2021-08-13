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
            input = new Input();
            consoleRenderer = new Renderer();
        }
        public void GameRun()
        {
            string playerInput = "";
            board.BoardTilesSetup();
            game = new GameHandler();
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
        }
        
            
            //Ta no bloco de notas

        }
        
    }