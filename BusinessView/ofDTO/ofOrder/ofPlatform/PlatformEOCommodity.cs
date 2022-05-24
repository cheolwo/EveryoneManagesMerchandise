using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofOrder;
using BusinessData.ofOrder.ofModel;

namespace BusinessView.ofDTO.ofOrder.ofPlatform
{
    [AutoMap(typeof(EOCommodity))]
    public class PlatformEOCommodity : PlatformEStatus
    {
        [Get] public int OutgoingQuantity { get; set; } // 출고수량
        [One(typeof(MOCommodity))]public string? MOCommodity { get; set; }
        [One(typeof(OCommodity))]public string? OCommodity { get; set; }
        [One(typeof(OrderCenter))]public string? OrderCenter { get; set; }
    }
}
