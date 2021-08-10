using System;
using Ghosts.Common;

namespace ConsoleApp
{
    public class SimulationSetup
    {
        ConsoleKeyInfo cki;
        private Grid gridRef;
        private Turn turn;
        private Parameters parameters;
        public SimulationSetup(Parameters paramtrs)
        {
            cki = new ConsoleKeyInfo();
            parameters = paramtrs;
            gridRef = new Grid(parameters.Xdim,parameters.Ydim);
            gridRef.GridSetup();
            turn = new Turn(gridRef, parameters);
            PaintCells();
        }
        public void NewTurn()
        {
            turn = new Turn(gridRef, parameters);
            turn.PlayEvents();
        }
        private void PaintCells()
        {
            int index = 0;
            for (int i= 0; i < gridRef.MaxRows; i++)
            {
                Console.WriteLine("");
                for (int z= 0; z < gridRef.MaxColumn; z++)
                {
                    Cell tempCell = gridRef.CellGroup[index];
                    if (tempCell.CellType == CellType.Rock)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else if (tempCell.CellType == CellType.Paper)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (tempCell.CellType == CellType.Scissors)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        
                    }
                    Console.Write($"  "); 
                    index++;  
                }
            }    
        }
        public void RunSimulation()
        {
            while (cki.Key != ConsoleKey.Spacebar)
                {
                    NewTurn();
                    PaintCells();
                    Console.WriteLine("");  
                }
        }
        
    }
}