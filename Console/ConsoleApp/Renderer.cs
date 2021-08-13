using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Renderer
    {
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
            Console.WriteLine("Press any key to return to the main manu");
        }

        public void PrintInstructions()
        {
            Console.WriteLine("");
            Console.WriteLine("Google Instructions for now");
            Console.WriteLine("Press any key to return to the main manu");
        }
    }
}