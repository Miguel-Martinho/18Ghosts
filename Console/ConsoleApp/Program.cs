using System;
using System.Globalization;
using MVC_Conway.Common;

namespace ConsoleApp
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Parameters parameters = new Parameters(
                Convert.ToInt16(args[0]), 
                Convert.ToInt16(args[1]), 
                float.Parse(args[2], CultureInfo.InvariantCulture),
                float.Parse(args[3], CultureInfo.InvariantCulture), 
                float.Parse(args[4], CultureInfo.InvariantCulture));

            Board board = new Board(parameters.Xdim, parameters.Ydim);
            foreach (Cell tempCell in board.GridRef.CellGroup)
                Console.WriteLine($"Row: {tempCell.CellPos.Row} , Column {tempCell.CellPos.Column}");
        }
    }
}
