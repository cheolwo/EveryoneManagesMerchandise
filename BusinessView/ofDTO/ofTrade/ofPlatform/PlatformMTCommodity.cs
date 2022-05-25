using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData;
using BusinessData.ofTrade.ofModel;
namespace BusinessView.ofTrade.ofPlatform
{
    [AutoMap(typeof(MTCommodity))]
    public class PlatformMTCommodity : PlatformMStatus
    {
        [Query][Get]public bool IsAccecptBillofLading {get; set;}
        [Query][Get]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Query][Get]public bool IsAcceptCredit {get; set;}
        [Query][Get]public string? ETCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
}
