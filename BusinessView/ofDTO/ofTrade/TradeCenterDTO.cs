using BusinessView.ofDTO.ofCommon;
using BusinessView.ofExternal.ofCommon;
namespace BusinessView.ofDTO.ofCommon.ofTrade
{
    public class TradeCenterDTO : CenterDTO
    {
        [Query(QueryCode.With)][Detail][Many(typeof(List<TCommodity>))]public string? TCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
    }
    public class TCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.ForeignKey)][Get]public string? PCommodityId {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
        [Query(QueryCode.With)][Detail][One(typeof(TradeCenter))]public string? TradeCenter {get; set;}
    }
    public class STCommodityDTO : STCommodityDTO
    {
        [Query(QueryCode.String)][Get]public string? BuyerId {get; set;} 
        [Query(QueryCode.String)][Get]public string? Message {get; set;}
        [Query(QueryCode.Int)][Get]public float Payed {get; set;}
        [Query(QueryCode.Bool)][Get]public bool IsAccept {get; set;}
        [Query(QueryCode.ForeignKey)][Query][Get]public string? MTCommodityId {get; set;}
        [Query(QueryCode.With)][Detail][One(typeof(TCommodity))]public string? TCommoditiy {get; set;}
    }
    public class MTCommodityDTO : MTCommodityDTO
    {
        [Query(QueryCode.Bool)][Get]public bool IsAccecptBillofLading {get; set;}
        [Query(QueryCode.Bool)][Get]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Query(QueryCode.Bool)][Get]public bool IsAcceptCredit {get; set;}
        [Query(QueryCode.ForeignKey)][Query][Get]public string? ETCommodityId {get; set;}
        [Query(QueryCode.With)][Detail][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
    public class ETCommodityDTO : ETCommodityDTO
    {
        [Query(QueryCode.ForeignKey)][Get]public string? MTCommodityId {get; set;}
        [Query(QueryCode.ForeignKey)][Get]public string? SWCommodityId {get; set;}
        [Query(QueryCode.With)][Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}