using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform
{
    [AutoMap(typeof(OCommodity))]
    [HttpDTOService(typeof(PlatformOCommodityService))]
    public class PlatformOCommodity : OCommodityDTO
    {
        
    }
}
