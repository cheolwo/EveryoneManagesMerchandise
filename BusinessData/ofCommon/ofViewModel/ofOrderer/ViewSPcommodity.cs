namespace BusinessData.ofCommon.ofViewModel.ofOrderer
{
    public class InputViewofSPCommodity
    {
        public string NameofCenter {get; set;}
        public string NameofProducter {get; set;}
        public string NameofPCommodity {get; set;}
        public string HsCode {get; set;}
        public string CoutryCode { get; set; }
    }
    public class ViewofSPCommodity
    {
        public string RestQuantity { get; set; }
        public string ProductableQuantity { get; set; }
        public string ProductCenterId { get; set; }
        public string ImageUrl { get; set; }
    }
    public class ViewofSTCommodity
    {
        public string NameofCommodity {get; set;}
        public string HsCode {get; set;}
        public string Quantity {get; set;}
        public string Price { get; set; }
        public string ClauseofQuantity {get; set;}   
        public string ClauseofQuality { get; set;}
        public string ClauseofCheckQuality { get; set; }
        public string ClauseofPacking { get; set;}
        public string GOCId {get; set;} 
    }
    
    public enum ConstQualityTerms { Sample, Mark, Brand, Type, Grade, Specification, Standard}
    public enum ConstQualityTermsofStandardQuality { FAQ, GMQ, USQ }
    public enum ConstQualityTermsofCheck { SQT, LQT }
    public enum ConstQualityTermsofGrain { TQ, RT, SD }
    public enum ConstQuantityTerms { GWT, LNW, NWT, NNWT}
    public enum ConstQuantityOptionTerms { MOL, AQT }
    public enum ConstIncorterms { EXW, FCA, FAS, FOB, CIF, CIP, CFR, DAT, DAP, DDP}

    public class SerachingOptionofViewSTCommodity
    {
        public string CountryCode {get; set;}
        public string HsCode {get; set;}
        public string NameofCommodity {get; set;}
        public string NameofProductCenter {get; set;}
    }
}