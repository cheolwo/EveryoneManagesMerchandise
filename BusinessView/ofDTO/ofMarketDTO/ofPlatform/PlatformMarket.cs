using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofPlatform;
using BusinessView.ofMarekt;

namespace BusinessView.ofMarket.ofPlatform
{
    public class PlatformMarket : PlatformCenter
    {
        [Get]public string NameofMarket { get; set; }
        [Many(ViewNameofMarket.PlatMarket)]public string PlatMarkets { get; set; }
        [Many(ViewNameofMarket.MCommodity)]public string MCommodities {get; set;}
        [Many(ViewNameofMarket.SMCommodity)]public string SMCommodities {get; set; }
        [Many(ViewNameofMarket.MMCommodity)]public string MMCommodities {get; set;}
        [Many(ViewNameofMarket.EMCommodity)]public string EMCommodities {get; set;}
    }
    public class PlatformPlatMarket : PlatformCenter
    {
        [Get]public string NameofPlatForm {get; set;}
        [Get]public string VendorId { get; set; }
        [Get]public string VendorPassword {get; set;}
        [Detail]public byte[] AccessKey { get; set; }
        [Detail]public byte[] SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity)] public string PMMCommodities {get; set;}
    }
    public class PlatformMCommodity : PlatformCommodity
    {
        [One(ViewNameofMarket.Market)]public string Market {get; set;}
        [One(ViewNameofMarket.DetailofMCommodity)]public string DetailofMCommodity { get; set; }  // Json 으로 처리한다.
        [One(ViewNameofMarket.Option)]public List<Option> Options { get; set; }
        [One(ViewNameofMarket.SMCommodity)]public string SMCommodities {get; set;}
        [One(ViewNameofMarket.MMCommodity)]public string MMCommodities {get; set;}
        [One(ViewNameofMarket.EMCommodity)]public string EMCommodities {get; set;}
    }
    public class PlatformSMCommodity : PlatformSStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public MCommodity MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.MMCommodity)]public string MMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public Market Market {get; set;}
        public string SWCommodityId {get; set;}
    }
    public class PlatformMMCommodity : PlatformMStatus
    {
        [Detail][One(ViewNameofMarket.PlatMarket)]public string PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public string Market {get; set;}
        [Detail][One(ViewNameofMarket.MCommodity)]public string MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.EMCommodity)]public string EMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.PMMCommodity)]public string PMMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.SMCommodity)]public string SMCommodity {get; set;}
    }
    public class PlatformEMCommodity : PlatformEStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public string MCommodity {get; set;}
        [Detail][One(ViewNameofMarket.MMCommodity)]public string MMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.PlatMarket)]public string PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public string Market {get; set;}
    }
}
