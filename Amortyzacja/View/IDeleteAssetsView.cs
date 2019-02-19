using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amortyzacja.Enums;

namespace Amortyzacja.View
{
    public interface IDeleteAssetsView
    {
        string SerialNumber { get; }
        string Pesel { get; }

        EAssets Assets { get; }
    }
}
