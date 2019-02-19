using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja.View
{
    interface ISoftwareAdditionView
    {
         string SoftwareType { get; }

         string SerialNumber { get; }

         DateTime PurchaseDate { get; }

         DateTime SubscriptionBeginning { get; }

         DateTime SubscriptionEnd { get; }
        double Price { get; }

    }
}
