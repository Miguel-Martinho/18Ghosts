using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Input
    {

        private string playerInput;
        private Renderer consoleRender;

        public Input(Renderer renderer)
        {
            consoleRender = renderer;
        }
        public void TitleScreenInput()
        {
            ConsoleKeyInfo playerInput;
            playerInput = Console.ReadKey();
            if (playerInput != null)
            {
                Console.Clear();
                consoleRender.PrintMainMenu();
            }
        }

        public string MainMenuInput()
        {
            consoleRender.PrintMainMenu();
            //Keeps running until players starts new game
            playerInput = Console.ReadLine();
            switch (playerInput)
            {
                //Starts new game
                case "1":
                    return playerInput;

                //Prints the game's Instructions
                case "2":
                    consoleRender.PrintInstructions();
                    break;

                //Prints the game's developers
                case "3":
                    consoleRender.PrintCredits();
                    break;

                //Prints Exit message and closes the game
                case "4":
                    consoleRender.PrintExitMsg();
                    return playerInput;
                //Returns the input here so the players goes back to main menu
                default:
                    consoleRender.PrintInputErrorMsg();
                    break;
            }
            //Asks the user for an input to leave the option screen
            Console.ReadKey();
            return playerInput;
        }
        public string DirectionalInput()
        {
            ConsoleKeyInfo playerInputinfo;
            playerInputinfo = Console.ReadKey();
            switch (playerInputinfo.Key)
            {
                //Sends information to go left
                case ConsoleKey.A:
                    playerInput = "left";
                    break;

                //Sends information to go up
                case ConsoleKey.W:
                    playerInput = "up";
                    break;

                //Sends information to go right
                case ConsoleKey.D:
                    playerInput = "right";
                    break;

                //Sends information to go down
                case ConsoleKey.S:
                    playerInput = "down";
                    break;
                case ConsoleKey.Enter:
                    playerInput = "enter"; 
                    break;
                default:
                    consoleRender.PrintInputErrorMsg();
                    break;
            }
            return playerInput;
        }
    }
}
