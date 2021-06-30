using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Conway.Common
{
    /// <summary>
    /// Class that controls the multiple events
    /// that occur during the simulation
    /// </summary>
    public class CellEvent
    {
        /// <summary>
        /// Random Class variable used to generate
        /// values, used to select random cells
        /// in the simulation
        /// </summary>
        private Random rng;

        /// <summary>
        /// Property used to reference the cell
        /// group in the simulation
        /// </summary>
        private IList<Cell> CellGroup { get; }

        /// <summary>
        /// Variables used to represent the 
        /// random selected cells
        /// </summary>
        private Cell c1;
        private Cell c2;


        /// <summary>
        /// Constructor for the CellEvent class
        /// </summary>
        /// <param name="cellGroup">Group of cells
        /// in the simulation</param>
        public CellEvent(IList<Cell> cellGroup)
        {
            rng = new Random();
            CellGroup = cellGroup;
        }

        /// <summary>
        /// Method used to "swicth" the cells types
        /// "moving" them along the simulation
        /// </summary>
        public void Movement()
        {
            CellSelector();
            Cell tempCell = c1;
            c1.CellType = c2.CellType;
            c2.CellType = tempCell.CellType;
        }

        /// <summary>
        /// Two random cells are selected
        /// and "Figth" accordingly with the rules
        /// of "Rock, Paper, Scissors"
        /// </summary>
        public void Fight()
        {
            ///Method seletects two random cells
            ///from te group
            CellSelector();

            ///Switch cased used to compare the 1st
            ///selected cell's type with the 2nd
            ///one. It compares both values and
            ///decides the "loser" using the rules
            ///of "Rock, Paper, Scissors".
            ///The loser becomes an empty cell;
            switch (c1.CellType)
            {

                case CellType.Rock:
                    if (c2.CellType == CellType.Scissors)
                    {

                        c1.CellType = CellType.Empty;
                        break;
                    }
                    else if (c2.CellType == CellType.Paper)
                    {
                        c2.CellType = CellType.Empty;
                        break;
                    }
                    else
                    {
                        break;
                    }

                case CellType.Paper:
                    if (c2.CellType == CellType.Scissors)
                    {
                        c1.CellType = CellType.Empty;
                        break;
                    }
                    else if (c2.CellType == CellType.Rock)
                    {
                        c1.CellType = CellType.Empty;
                        break;
                    }
                    else
                    {
                        break;
                    }

                case CellType.Scissors:
                    if (c2.CellType == CellType.Rock)
                    {
                        c1.CellType = CellType.Empty;
                        break;
                    }
                    else if (c2.CellType == CellType.Paper)
                    {
                        c2.CellType = CellType.Empty;
                        break;
                    }
                    else
                    {
                        break;
                    }

                default:
                    break;
            }
        }

        /// <summary>
        /// Method used to multiply the number of
        /// cells using its type. If one of the chosen
        /// cells is of the Empty type, it changes
        /// its type to the neighbourcell
        /// </summary>
        public void Reproduce()
        {
            CellSelector();
            if (c1.CellType == CellType.Empty ||
                c2.CellType == CellType.Empty)
            {
                if (c1.CellType == CellType.Empty)
                    c1.CellType = c2.CellType;
                else
                    c2.CellType = c1.CellType;
            }
        }

        /// <summary>
        /// Method used to select two random cells
        /// from the simulation
        /// </summary>
        private void CellSelector()
        {
            //Variables used to randomly select 
            //the cells
            int c1Selector = rng.Next(CellGroup.Count);
            int c2Selector = rng.Next(1, 4);

            c1 = CellGroup[c1Selector];

            //Loop that goes through the cell
            //collection and compares the current
            //cell positions with the 1st randomly
            //selected cell position. And compares
            //the second random value in order to
            //choose the position of the neighour cell
            foreach (Cell tempCell in CellGroup)
            {
                ///If the 2nd random value is 1
                ///it will select the top neighbour
                ///cell
                if (tempCell.CellPos.Column ==
                    c1.CellPos.TopCellPos
                    && c2Selector == 1)
                    c2 = tempCell;

                ///If the 2nd random value is 2
                ///it will select the bottom
                ///neighbour cell
                else if (tempCell.CellPos.Column
                    == c1.CellPos.BotCellPos
                    && c2Selector == 2)
                    c2 = tempCell;

                ///If the 2nd random value is 3
                ///it will select the left neighbour
                ///cell
                else if (tempCell.CellPos.Row
                    == c1.CellPos.LeftCellPos
                    && c2Selector == 3)
                    c2 = tempCell;

                ///If the 2nd random value is 1
                ///it will select the right neighbour
                ///cell
                else if (tempCell.CellPos.Row
                    == c1.CellPos.RightCellPos
                    && c2Selector == 4)
                    c2 = tempCell;

            }
        }

    }
}
