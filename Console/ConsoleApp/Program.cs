using System;
using System.Globalization;
using Ghosts.Common;

namespace ConsoleApp
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            SimulationSetup setup = new SimulationSetup(parameters);
            setup.RunSimulation();
        }
    }
}
