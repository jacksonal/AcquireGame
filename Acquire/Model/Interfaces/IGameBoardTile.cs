using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.Model.Interfaces
{
    interface IGameBoardTile
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is playable.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is playable; otherwise, <c>false</c>.
        /// </value>
        bool IsPlayable { get; }
    }
}
