using System;
using MVC_Conway.Common;

namespace ConsoleApp
{
    public class Board
    {
        public Grid GridRef {get; private set;}
        public Board(short xdim,short ydim)
        {
            GridRef = new Grid(xdim,ydim);
            GridRef.GridSetup();
        }
        public void Refresh()
        {
            
        }
    }
}