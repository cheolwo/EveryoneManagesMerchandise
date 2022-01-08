namespace BusinessData.ofCommon.ofKamis.ofModel
{
    public class KamisPart : Entity
    {
        public List<KamisCommodityCode> KamisCommodityCodes {get; set;`}
    }
    public class KamisCommodity : Entity
    {
        public KamisPart kamisPart {get; set;}
        public List<KindofCommodity> KindsofCommodity {get; set;}
    }
    public class KindofCommodity : Entity
    {
        public string WholesaleShippingUnit {get; set;}
        public string WholeSaleShippingUnizSize {get; set;}
        public string RetailShippingUnit {get; set;}
        public string RetailShippingUnitSize {get; set;}
        public string EcoFriendlyAgriculturalProductShippingUnit {get; set;}
        public string EcoFriendlyAgriculturalProductShippingUnitSize {get; set;}
        public string WholeSaleGrade {get; set;}
        public string WholeSaleRetailGrade {get; set;}
        public string EcoFriendlyGrade {get; set;}
        public KamisCommodity KamisCommodity {get; set;}
    }
}