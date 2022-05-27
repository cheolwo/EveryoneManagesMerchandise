using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofCommon.ofTrade
{
    public class TradeCenterDTO : CenterDTO
    {
        [Detail][Many(typeof(List<TCommodity>))]public string? TCommodities {get; set;}
        [Detail][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Detail][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Detail][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
    }
    public class TCommodityDTO : CommodityDTO
    {
        [Query][Get]public string? PCommodityId {get; set;}
        [Detail][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Detail][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Detail][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
        [Detail][One(typeof(TradeCenter))]public string? TradeCenter {get; set;}
    }
    public class STCommodityDTO : STCommodityDTO
    {
        [Query][Get]public string? BuyerId {get; set;} 
        [Query][Get]public string? Message {get; set;}
        [Query][Get]public float Payed {get; set;}
        [Query][Get]public bool IsAccept {get; set;}
        [Query][Get]public string? MTCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommoditiy {get; set;}
    }
    public class MTCommodityDTO : MTCommodityDTO
    {
        [Query][Get]public bool IsAccecptBillofLading {get; set;}
        [Query][Get]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Query][Get]public bool IsAcceptCredit {get; set;}
        [Query][Get]public string? ETCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
    public class ETCommodityDTO : ETCommodityDTO
    {
        [Query][Get]public string? MTCommodityId {get; set;}
        [Query][Get]public string? SWCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}