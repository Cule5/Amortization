//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amortyzacja
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hardware
    {
        public int IdHardware { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<int> Workers_IdWorker { get; set; }
        public Nullable<int> Amortizations_IdAmortization { get; set; }
        public int Purchases_IdPurchase { get; set; }
    
        public virtual Amortization Amortization { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual Worker Worker { get; set; }
    }
}