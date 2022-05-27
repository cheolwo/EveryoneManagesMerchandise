using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofMarket
{
    public class MarketDTO : CenterDTO
    {
        [Query][Get]public string NameofMarket { get; set; }
        [Many(ViewNameofMarket.PlatMarket, typeof(List<PlatMarket>))]public string? PlatMarkets { get; set; }
        [Many(ViewNameofMarket.MCommodity, typeof(List<MCommodity>))]public string? MCommodities {get; set;}
        [Many(ViewNameofMarket.SMCommodity, typeof(List<SMCommodity>))]public string? SMCommodities {get; set; }
        [Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
    }
    public class PlatMarketDTO : CenterDTO
    {
        [Query][Get]public string? NameofPlatForm {get; set;}
        [Query][Get]public string? VendorId { get; set; }
        [Get]public string? VendorPassword {get; set;}
        [Detail]public Binary? AccessKey { get; set; }
        [Detail]public Binary? SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity, typeof(List<PMMCommodity>))] public string? PMMCommodities {get; set;}
    }
    public class MCommodityDTO : CommodityDTO
    {
        [One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [One(ViewNameofMarket.DetailofMCommodity, typeof(DetailofMCommodity))]public string? DetailofMCommodity { get; set; }  // Json 으로 처리한다.
        [One(ViewNameofMarket.Option, typeof(Option))]public string? Options { get; set; }
        [Many(ViewNameofMarket.SMCommodity, typeof(List<SMCommodity>))]public string? SMCommodities {get; set;}
        [Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
    }
    public class SMCommodityDTO : SStatusDTO
    {
        [Detail][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string? MMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [Query][Get]public string? SWCommodityId {get; set;}
    }
    public class MMCommodityDTO : MStatusDTO
    {
        [Detail][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string? PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
        [Detail][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string? EMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.PMMCommodity, typeof(PMMCommodity))]public string? PMMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.SMCommodity, typeof(SMCommodity))]public string? SMCommodity {get; set;}
    }
    public class EMCommodityDTO : EStatusDTO
    {
        [Detail][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string? MCommodity {get; set;}
        [Detail][One(ViewNameofMarket.MMCommodity, typeof(MMCommodity))]public string? MMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string? PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market, typeof(Market))]public string? Market {get; set;}
    }
}