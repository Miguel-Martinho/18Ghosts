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

        public void PlaceGhostErrorMsg()
        {
            Console.WriteLine("Ghosts must be placed on Carpet Tiles");
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
        public void RenderBoard(Tile[,] tileArray, Tile higlightedTile)
        {

            /*Console.Write(" ___________________");*/
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("");
                
                for (int j = 0; j < columns; j++)
                {

                    if (j == 0)
                    {
                        Console.Write(@"{0}.    ", i);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("|");
                    }
                    //highlighted Tile check
                    if (higlightedTile.TilePos.Row == i &&
                    higlightedTile.TilePos.Column == j)
                    {
                        if (Console.BackgroundColor == ConsoleColor.Black)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                    }
                    //Carpet check
                    if (tileArray[i, j].TileType == TileType.Carpet)
                   
                    {
                        if (tileArray[i, j].Color == Color.Red)
                        {
                            
                            Console.BackgroundColor = ConsoleColor.DarkRed; 

                            CheckToDraw(tileArray[i,j]);
                        }
                        else if (tileArray[i, j].Color == Color.Blue)
                        {
                            
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                           
                            CheckToDraw(tileArray[i,j]);
                        }
                        else if (tileArray[i, j].Color == Color.Yellow)
                        {
                            
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            
                            CheckToDraw(tileArray[i,j]);
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("|");
                    }
                    //portal check
                    else if (tileArray[i, j].TileType == TileType.Portal)
                    {

                        if (tileArray[i, j].Color == Color.Red)
                        {
                            
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                        }
                        else if (tileArray[i, j].Color == Color.Blue)
                        {
                            
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                        }
                        else if (tileArray[i, j].Color == Color.Yellow)
                        {
                            
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                        Console.Write(" P ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("|");
                    }
                    //Mirror check
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write(" M ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("|");
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
        }

        public void CheckToDraw(Tile tile)
        {
            if (tile.IsEmpty)
                Console.Write("   ");
            else
            {
                if (tile.Ghost.Player == 1)
                {
                    Console.Write(" 1 ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(" 2 ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

        }
    }
}
