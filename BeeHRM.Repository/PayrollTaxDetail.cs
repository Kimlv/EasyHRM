//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeeHRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class PayrollTaxDetail
    {
        public int DetailId { get; set; }
        public int MasterId { get; set; }
        public decimal MaxAmount { get; set; }
        public int OrderNumber { get; set; }
        public decimal Percentage { get; set; }
    
        public virtual PayrollTaxSetup PayrollTaxSetup { get; set; }
    }
}
