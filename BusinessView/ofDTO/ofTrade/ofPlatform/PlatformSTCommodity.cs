using AutoMapper;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofTrade.ofPlatform
{
    [AutoMap(typeof(STCommodity))]
    public class PlatformSTCommodity : PlatformSStatus
    {
        [Get]public string? BuyerId {get; set;} 
        [Get]public string? Message {get; set;}
        [Get]public float Payed {get; set;}
        [Get]public bool IsAccept {get; set;}
        [Get]public string? MTCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommoditiy {get; set;}
    }
}
