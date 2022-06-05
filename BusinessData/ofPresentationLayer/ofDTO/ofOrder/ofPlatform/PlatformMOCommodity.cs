using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform
{
    [AutoMap(typeof(MOCommodity))]
    [HttpDTOService(typeof(PlatformMOCommodityService))]
    public class PlatformMOCommodity : MOCommodityDTO
    {
        
    }
}
