using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofTrade.ofPlatform
{
    public class PlatformSTCommodity : PlatformSStatus
    {
        public string? BuyerId {get; set;} 
        public string? Message {get; set;}
        public float Payed {get; set;}
        public bool IsAccept {get; set;}
        public string? MTCommodityId {get; set;}
        public string? TCommoditiy {get; set;}
    }
}
