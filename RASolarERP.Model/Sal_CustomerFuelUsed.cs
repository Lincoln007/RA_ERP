//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarERP.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sal_CustomerFuelUsed
    {
        public Sal_CustomerFuelUsed()
        {
            this.Sal_Customer = new HashSet<Sal_Customer>();
            this.Sal_CustomerPrePost = new HashSet<Sal_CustomerPrePost>();
        }
    
        public string CustomerFuelUsedID { get; set; }
        public string Description { get; set; }
        public byte SortingOrder { get; set; }
        public string IDCOLCustomerFuelUsedID { get; set; }
        public byte Status { get; set; }
    
        public virtual ICollection<Sal_Customer> Sal_Customer { get; set; }
        public virtual ICollection<Sal_CustomerPrePost> Sal_CustomerPrePost { get; set; }
    }
}
