using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofExternal.ofCommon;
using NMemory.Data;

namespace BusinessView.ofDTO.ofMarket
{
    public class MarketDTO : CenterDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string NameofMarket { get; set; }
        [Query(QueryCode.With)][Many(ViewNameofMarket.PlatMarket, typeof(List<PlatMarket>))]public string? PlatMarkets { get; set; }
        [Query(QueryCode.With)][Many(ViewNameofMarket.MCommodity, typeof(List<MCommodity>))]public string? MCommodities {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.SMCommodity, typeof(List<SMCommodity>))]public string? SMCommodities {get; set; }
        [Query(QueryCode.With)][Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
    }
    public class PlatMarketDTO : CenterDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? NameofPlatForm {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? VendorId { get; set; }
        [View(ViewMode.Get)]public string? VendorPassword {get; set;}
        [View(ViewMode.Detail)]public Binary? AccessKey { get; set; }
        [View(ViewMode.Detail)]public Binary? SecreatKey { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofMarket.PMMCommodity, typeof(List<PMMCommodity>))] public string? PMMCommodities {get; set;}
    }
    public class MCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.With)][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [Query(QueryCode.With)][One(ViewNameofMarket.DetailofMCommodity, typeof(DetailofMCommodity))]public string? DetailofMCommodity { get; set; }  // Json 으로 처리한다.
        [Query(QueryCode.With)][One(ViewNameofMarket.Option, typeof(Option))]public string? Options { get; set; }
        [Query(QueryCode.With)][Many(ViewNameofMarket.SMCommodity, typeof(List<SMCommodity>))]public string? SMCommodities {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
    }
    public class SMCommodityDTO : SStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? SWCommodityId {get; set;}
    }
    public class MMCommodityDTO : MStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string? PlatMarket {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.PMMCommodity, typeof(PMMCommodity))]public string? PMMCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.SMCommodity, typeof(SMCommodity))]public string? SMCommodity {get; set;}
    }
    public class EMCommodityDTO : EStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.MMCommodity, typeof(MMCommodity))]public string? MMCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string? PlatMarket {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
    }
}