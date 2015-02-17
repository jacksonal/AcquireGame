using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.Model.Interfaces
{
    interface IGameEngine
    {
        IGameBoard Board { get; }

        IHotel GetHotel(string Name);
    }
}
