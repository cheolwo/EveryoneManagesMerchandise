using BusinessData.ofTrade.ofModel;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofTrade.ofPlatform
{
    public class PlatformTradeCenter : PlatformCenter
    {
        public string TCommodities {get; set;}
    }
    public class PlatformTCommodity : PlatformCommodity
    {
        public string PCommodityId {get; set;}
        public string STCommodities {get; set;}
        public string MTCommodities {get; set;}
        public string ETCommodities {get; set;}
        public string TradeCenter {get; set;}
    }
    public class PlatformSTCommodity : PlatformSStatus
    {
        public string BuyerId {get; set;} 
        public string Message {get; set;}
        public float Payed {get; set;}
        public bool IsAccept {get; set;}
        public string MTCommodityId {get; set;}
        public string TCommoditiy {get; set;}
    }
    public class PlatformMTCommodity : PlatformMStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string ETCommodityId {get; set;}
        public string TCommodity {get; set;}
    }
    public class PlatformETCommodity : PlatformEStatus
    {
        public string MTCommodityId {get; set;}
        public string SWCommodityId {get; set;}
        public string TCommodity { get; set; }
    }
}
