using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofOrder;
using BusinessData.ofOrder.ofModel;

namespace BusinessView.ofDTO.ofOrder.ofPlatform
{
    [AutoMap(typeof(MOCommodity))]
    public class PlatformMOCommodity : PlatformMStatus
    {
        [Detail][One(typeof(OCommodity))] public string? OCommodity { get; set; }
        [Detail][One(typeof(OrderCenter))] public string? OrderCenter { get; set; }
        [Detail][One(typeof(SOCommodity))] public string? SOCommodity { get; set; }
        [Detail][Many(typeof(List<EOCommodity>))]public string? EOCommodities { get; set; }
    }
}
