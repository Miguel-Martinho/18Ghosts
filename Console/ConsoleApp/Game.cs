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
        private Tile previousTile;
        private Tile firstTile;
        private Tile secondTile;
        private bool placingPhase;
        private bool playingphase;
        private byte column;
        private byte row;

        public Game()
        {
            column = 5;
            row = 5;
            board = new Board(column, row);
            game = new GameHandler();
            consoleRenderer = new Renderer(column, row);
            input = new Input(consoleRenderer);
            placingPhase = true;
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
            previousTile = board.TileArray[0, 0];
            consoleRenderer.RenderBoard(board.TileArray, previousTile);

            //player 1 plays twice
            //MISSING: if tile is invalid 
            firstTile = ValidInputLoop(previousTile, playerInput);

            if (game.PlaceGhost(firstTile) == false)
            {
                consoleRenderer.PlaceGhostErrorMsg();
            }

            while (placingPhase == true)
            {
                firstTile = ValidInputLoop(previousTile, playerInput);

                if (game.PlaceGhost(firstTile) == false)
                {
                    consoleRenderer.PlaceGhostErrorMsg();
                }
                else
                    game.ChangeCurrentPlayer();
            }

            while (playingphase == true)
            {
                firstTile = ValidInputLoop(previousTile, playerInput);

                secondTile = ValidInputLoop(previousTile, playerInput);

                if (secondTile.IsEmpty == true)
                    firstTile.Ghost.Movement(secondTile);
                else
                    game.Fight(firstTile.Ghost, secondTile.Ghost);

                game.ChangeCurrentPlayer();
            }
            //while loop for player to select a Tile
        }
        //Ta no bloco de notas

        //is responsible for keeping a loop until the input is valid 
        //recieves tile because i can be the first or second selected tile
        //console renders in here because its moving the cursor every
        //while iteration
        private Tile ValidInputLoop(Tile versaTile, string playerInput)
        {
            while (playerInput != "enter")
            {
                playerInput = input.DirectionalInput();

                versaTile = SelectTile
                (board.TileArray, playerInput, previousTile);

                previousTile = versaTile;

                consoleRenderer.RenderBoard(board.TileArray, versaTile);
            }
            playerInput = "";
            return versaTile;
        }  
        
        //is responsible selecting a tile according to input
        private Tile SelectTile(Tile[,] board, string stringinput,
        Tile currentTile)
        {
            if (stringinput == "left")
            {
                if (currentTile.TilePos.Column == 0)
                    currentTile = board[currentTile.TilePos.Row, column -1];
                else
                currentTile = 
                board[currentTile.TilePos.Row, currentTile.TilePos.Column -1];
            }
            else if (stringinput == "up")
            { 
                if (currentTile.TilePos.Row == 0)
                    currentTile = board[row -1, currentTile.TilePos.Column];   
                else
                currentTile =
                board[currentTile.TilePos.Row -1, currentTile.TilePos.Column]; 
            }
            else if (stringinput == "right")
            {
                if (currentTile.TilePos.Column == column -1)
                    currentTile = board[currentTile.TilePos.Row, 0];
                else
                currentTile = 
                board[currentTile.TilePos.Row, currentTile.TilePos.Column +1];
            }
            else if (stringinput == "down")
            {
                if (currentTile.TilePos.Row == row -1)
                    currentTile = board[0, currentTile.TilePos.Column];
                else
                currentTile = 
                board[currentTile.TilePos.Row +1, currentTile.TilePos.Column];
            }
            return currentTile;
        }
    }
}