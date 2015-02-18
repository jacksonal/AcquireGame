using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.Model.Interfaces
{
    public interface IHotel
    {
        string Name { get; }

        int AvailableStock { get; }

        int StockValue { get; }

        IStock GetStock();
    }
}
