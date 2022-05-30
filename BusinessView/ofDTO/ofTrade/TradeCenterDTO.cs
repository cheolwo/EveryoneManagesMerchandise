using BusinessView.ofExternal.ofCommon;
using BusinessData;
using BusinessData.ofTrade.ofModel;

namespace BusinessView.ofDTO.ofCommon.ofTrade
{
    public class TradeCenterDTO : CenterDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<TCommodity>))]public string? TCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
    }
    public class TCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.ForeignKey)][View(ViewMode.Get)]public string? PCommodityId {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<STCommodity>))]public string? STCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<MTCommodity>))]public string? MTCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<ETCommodity>))]public string? ETCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(TradeCenter))]public string? TradeCenter {get; set;}
    }
    public class STCommodityDTO : SStatusDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? BuyerId {get; set;} 
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? Message {get; set;}
        [Query(QueryCode.Int)][View(ViewMode.Get)]public float Payed {get; set;}
        [Query(QueryCode.Bool)][View(ViewMode.Get)]public bool IsAccept {get; set;}
        [Query(QueryCode.ForeignKey)][View(ViewMode.Get)]public string? MTCommodityId {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(TCommodity))]public string? TCommoditiy {get; set;}
    }
    public class MTCommodityDTO : MStatusDTO
    {
        [Query(QueryCode.Bool)][View(ViewMode.Get)]public bool IsAccecptBillofLading {get; set;}
        [Query(QueryCode.Bool)][View(ViewMode.Get)]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Query(QueryCode.Bool)][View(ViewMode.Get)]public bool IsAcceptCredit {get; set;}
        [Query(QueryCode.ForeignKey)][View(ViewMode.Get)]public string? ETCommodityId {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
    public class ETCommodityDTO : EStatusDTO
    {
        [Query(QueryCode.ForeignKey)][View(ViewMode.Get)]public string? MTCommodityId {get; set;}
        [Query(QueryCode.ForeignKey)][View(ViewMode.Get)]public string? SWCommodityId {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}