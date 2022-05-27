using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofOrder
{
    public class EOCommodityDTO : EStatusDTO
    {
        [Query][Get]public string? Price { get; set; }
        [Query][Get]public string? QualityTerms { get; set; }
        [Query][Get]public string? Incorterms { get; set; }
        [Detail][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Detail][One(typeof(OrderCenter))]public string? OrderCenter { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity,typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
    }
    public class MOCommodityDTO : MStatusDTO
    {
        [Detail][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Detail][One(typeof(OrderCenter))] public string? OrderCenter { get; set; }
        [Detail][One(typeof(SOCommodity))] public string? SOCommodity { get; set; }
        [Detail][Many(typeof(List<EOCommodity>))]public string? EOCommodities { get; set; }
    }
    public class SOCommodityDTO : SStatusDTO
    {
        [Query][Get]public string? Price { get; set; }
        [Query][Get]public string? QualityTerms { get; set; }
        [Query][Get]public string? Incorterms { get; set; }
        [Detail][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Detail][One(typeof(OrderCenter))]public string? OrderCenter { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity,typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
    }
    public class OCommodityDTO : CommodityDTO
    {
        [Query][Get] public string? OrderId { get; set; } // 이거의 존재는 Order Table 이라는 테이블의 존재를 의미하는데..
        [Query][Get]public string? OrderType { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity, typeof(List<SOCommodity>))] public string? SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity, typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity, typeof(List<EOCommodity>))] public string? EOCommodities { get; set; }
        [Detail][One(typeof(OrderCenter))] public string OrderCenter { get; set; }
    }
    public class OrderCenterDTO : CenterDTO
    {
        [Detail][Many(ViewNameofOrderCenter.OCommodity, typeof(List<OCommodity>))] public string? OCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity, typeof(List<SOCommodity>))] public string? SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity, typeof(List<MOCommodity>))] public string? MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity, typeof(List<EOCommodity>))] public string? EOCommodities { get; set; }
    }
}