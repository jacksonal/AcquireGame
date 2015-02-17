using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.Model.Interfaces
{
    interface IGameBoardSlot
    {
        /// <summary>
        /// Gets or sets the name of the tile.
        /// </summary>
        /// <value>
        /// The name of the tile.
        /// </value>
        string TileName { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is full.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is full; otherwise, <c>false</c>.
        /// </value>
        bool IsFull { get; }
    }
}
