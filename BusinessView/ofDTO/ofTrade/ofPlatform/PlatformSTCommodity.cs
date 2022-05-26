using AutoMapper;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofTrade.ofPlatform
{
    [AutoMap(typeof(STCommodity))]
    public class PlatformSTCommodity : PlatformSStatus
    {
        [Query][Get]public string? BuyerId {get; set;} 
        [Query][Get]public string? Message {get; set;}
        [Query][Get]public float Payed {get; set;}
        [Query][Get]public bool IsAccept {get; set;}
        [Query][Get]public string? MTCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommoditiy {get; set;}
    }
}
