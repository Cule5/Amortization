using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.View
{
    public interface IHardwareAdditionView
    {
        string SerialNumber { get; }
        string HardwareType { get; }
        DateTime PurchaseDate { get; }
        double Price { get; }
    }
}
