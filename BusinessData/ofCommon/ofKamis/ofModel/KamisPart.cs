namespace BusinessData.ofCommon.ofKamis.ofModel
{
    public abstract class KamisEntity : Entity
    {

    }
    public class KamisPart : KamisEntity
    {
        public List<KamisCommodityCode> KamisCommodityCodes {get; set;}
    }
    public class KamisCommodity : KamisEntity
    {
        public string KamisPartId {get; set;}
        public KamisPart KamisPart {get; set;}
        public List<KamisKindofCommodity> KamisKindsofCommodity {get; set;}
    }
    public class KamisKindofCommodity : KamisEntity
    {
        public string WholesaleShippingUnit {get; set;}
        public string WholeSaleShippingUnizSize {get; set;}
        public string RetailShippingUnit {get; set;}
        public string RetailShippingUnitSize {get; set;}
        public string EcoFriendlyAgriculturalProductShippingUnit {get; set;}
        public string EcoFriendlyAgriculturalProductShippingUnitSize {get; set;}
        public List<KamisGrade> WholeSaleGrades {get; set;}
        public List<KamisGrade> RetailSaleGrades {get; set;}
        public List<KamisGrade> EcoFriendlyGrades {get; set;}
        public List<KamisDayPrice> KamisDayPrices {get; set;}
        public KamisCommodity KamisCommodity {get; set;}
        public string KamisCommodityId {get; set;}
    }
    public class KamisGrade
    {
        public string Code {get; set;}
        public string Name {get; set;}
    }
    public class KamisCountryAdministrationPart : KamisEntity
    {
        public List<KamisSubCountryAdministrationPart> KamisSubCountryAdministrationParts {get; set;}
    }
    public class KamisSubCountryAdministrationPart : KamisEntity
    {
        public string KamisCountryAdministrationPartId {get; set;}
        public KamisCountryAdministrationPart KamisCountryAdministrationPart {get; set;}
        public List<KamisMarket> KamisMarkets {get; set;}
    }
    public class KamisMarket : KamisEntity
    {
        public string KamisSubCountryAdministrationPartId {get; set;}
        public SubCountryAdministrationPart KamisSubCountryAdministrationPart {get; set;}
        public List<DayPrice> KamisDaysPrices {get; set;}
    }
    public class KamisDayPrice : KamisEntity
    {
        public string KamisMarketId {get; set;}
        public string KamisKindofCommodityId {get; set;}
        public KamisMarket KamisMarket {get; set;}
        public KamisKindofCommodity KamisKindofCommodity {get; set;}
    }
}