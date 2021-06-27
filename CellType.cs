using System;

namespace MVC_Conway.Common
{
    /// <summary>
    /// Enum used to represent the different types
    /// of cells in the simulation
    /// </summary>
    [Flags]
    public enum CellType
    {
        /// <summary>
        /// Represents an empty cell
        /// </summary>
        Empty = 0,

        /// <summary>
        /// Represents a Rock Cell Type
        /// </summary>
        Rock = 1,
        
        /// <summary>
        /// Represents a Rock Cell Type
        /// </summary>
        Paper = 2,

        /// <summary>
        /// Represents a Scissors Cell Type
        /// </summary>
        Scissors = 4

    }
}
