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
    
    public partial class Common_Sys_LocationType
    {
        public Common_Sys_LocationType()
        {
            this.Common_LocationInfo = new HashSet<Common_LocationInfo>();
        }
    
        public byte LocationTypeID { get; set; }
        public string TypeDescription { get; set; }
        public string StartCode { get; set; }
        public string EndCode { get; set; }
        public byte Status { get; set; }
    
        public virtual ICollection<Common_LocationInfo> Common_LocationInfo { get; set; }
    }
}