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
    
    public partial class CollectionEfficiencyByUnitOfficeSummary
    {
        public string Zone_Name { get; set; }
        public string Region_Name { get; set; }
        public string Unit_Code { get; set; }
        public string Unit_Name { get; set; }
        public Nullable<double> CM_Receivable__One_Installment__4 { get; set; }
        public Nullable<double> CM_CashCollection_5 { get; set; }
        public double CM_SystemReturn_6 { get; set; }
        public Nullable<double> CM_AdvanceAdjustment_7 { get; set; }
        public Nullable<double> CM_TotalCollection_8_5_6_7 { get; set; }
        public Nullable<double> CM_CollectionEfficiency_9_8_4_ { get; set; }
        public Nullable<double> OD_OverdueInCurrentMonth_10_4_8 { get; set; }
        public Nullable<double> OD_OverdueBalanceAtTheEndOfLastMonth_11 { get; set; }
        public Nullable<double> OD_TotalOverdueUpToCurrentMonth_12_10_11 { get; set; }
        public Nullable<double> OD_RecoveryFromOverdueInCurrentMonth_13 { get; set; }
        public double OD_SystemReturn_14 { get; set; }
        public Nullable<double> OD_OverdueBalanceAtTheEndOfCurrentMonth_15_12_13_14 { get; set; }
        public Nullable<double> OverallCollectionEfficiency_16__8_13_14___4_11__ { get; set; }
        public Nullable<double> AD_AdvanceBalanceAtTheEndOfLastMonth_17 { get; set; }
        public Nullable<double> AD_AdvanceReceivedInCurrentMonth_18 { get; set; }
        public Nullable<double> AD_TotalAdvance_19_17_18 { get; set; }
        public Nullable<double> AD_AdvanceAdjustmentInCurrentMonth_20 { get; set; }
        public double AD_SystemReturn_21 { get; set; }
        public Nullable<double> AD_AdvanceBalanceAfterAdjustment_22_19_20_21 { get; set; }
    }
}
