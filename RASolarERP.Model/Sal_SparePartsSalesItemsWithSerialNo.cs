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
    
    public partial class Sal_SparePartsSalesItemsWithSerialNo
    {
        public string LocationCode { get; set; }
        public string SPSSeqNo { get; set; }
        public byte CompSeqNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemSerialNo { get; set; }
        public Nullable<byte> RefStoreLocation { get; set; }
        public byte Status { get; set; }
    
        public virtual Sal_SparePartsSalesItems Sal_SparePartsSalesItems { get; set; }
        public virtual Inv_ItemNItemCategoryWithSerialNoMaster Inv_ItemNItemCategoryWithSerialNoMaster { get; set; }
    }
}