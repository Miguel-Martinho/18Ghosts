using System;
using System.Collections.Generic;
using System.Text;
using Ghosts.Common;

namespace ConsoleApp
{
    public class Renderer
    {
        private byte columns;
        private byte rows;

        public Renderer(byte maxcolumns, byte maxrows)
        {
            columns = maxcolumns;
            rows = maxrows;
        }
        public void PrintTitleScreen()
        {
            Console.WriteLine(" _____________________________________________");
            Console.WriteLine("|  __  ___     _____ _               _        |");
            Console.WriteLine(@"| /_ |/ _ \   / ____| |             | |       |");
            Console.WriteLine(@"|  | | (_) | | |  __| |__   ___  ___| |_ ___  |");
            Console.WriteLine(@"|  | |> _ <  | | |_ | '_ \ / _ \/ __| __/ __| |");
            Console.WriteLine(@"|  | | (_) | | |__| | | | | (_) \__ \ |_\__ \ |");
            Console.WriteLine(@"|  |_|\___/   \_____|_| |_|\___/|___/\__|___/ |");
            Console.WriteLine("|_____________________________________________|");
            Console.WriteLine("");
            Console.WriteLine("------------ Press any key to Start -----------");
        }

        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine(" _____________________________________________");
            Console.WriteLine("|  __  ___     _____ _               _        |");
            Console.WriteLine(@"| /_ |/ _ \   / ____| |             | |       |");
            Console.WriteLine(@"|  | | (_) | | |  __| |__   ___  ___| |_ ___  |");
            Console.WriteLine(@"|  | |> _ <  | | |_ | '_ \ / _ \/ __| __/ __| |");
            Console.WriteLine(@"|  | | (_) | | |__| | | | | (_) \__ \ |_\__ \ |");
            Console.WriteLine(@"|  |_|\___/   \_____|_| |_|\___/|___/\__|___/ |");
            Console.WriteLine("|_____________________________________________|");
            Console.WriteLine("");
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Instructions");
            Console.WriteLine("3. Credits");
            Console.WriteLine("4. Quit");

        }

        public void PrintInputErrorMsg()
        {
            Console.WriteLine("Option Unkown");
        }

        public void PrintExitMsg()
        {
            Console.WriteLine("See ya.");
        }

        public void PrintCredits()
        {
            Console.WriteLine("");
            Console.WriteLine(" ____________________");
            Console.WriteLine("|                    |");
            Console.WriteLine("| Developed by:      |");
            Console.WriteLine("| Miguel Martinho    |");
            Console.WriteLine("| Goncalo Vila Verde |");
            Console.WriteLine("|____________________|");
            Console.WriteLine("");
            Console.WriteLine("Press any key to return to the main menu");
        }

        public void PrintInstructions()
        {
            Console.WriteLine("");
            Console.WriteLine("Google Instructions for now");
            Console.WriteLine("Press any key to return to the main menu");
        }
        public void RenderBoard(Tile[,] tileArray)
        {
            Console.Write(" ___________________");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("");
                
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("|");
                    }
                    if (tileArray[i, j].TileType == TileType.Carpet)
                   
                    {
                        if (tileArray[i, j].Color == Color.Red)
                        {
                            Console.Write("_1_|");
                            /*Console.BackgroundColor = ConsoleColor.Red;*/
                        }
                        else if (tileArray[i, j].Color == Color.Blue)
                        {
                            Console.Write("_2_|");
                            /*Console.BackgroundColor = ConsoleColor.Blue;*/
                        }
                        else if (tileArray[i, j].Color == Color.Yellow)
                        {
                            Console.Write("_3_|");
                            /*Console.BackgroundColor = ConsoleColor.Yellow;*/
                        }
                    }
                    else if (tileArray[i, j].TileType == TileType.Portal)
                    {

                        Console.Write("_P_|");
                    }
                    else
                    {
                        Console.Write("_M_|");
                        /*Console.BackgroundColor = ConsoleColor.Gray;*/
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
