using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofTrade.ofPlatform
{
    public class PlatformMTCommodity : PlatformMStatus
    {
        [Get]public bool IsAccecptBillofLading {get; set;}
        [Get]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Get]public bool IsAcceptCredit {get; set;}
        [Get]public string? ETCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
}
