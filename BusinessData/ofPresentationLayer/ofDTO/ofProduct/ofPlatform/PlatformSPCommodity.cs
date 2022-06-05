using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform
{
    [AutoMap(typeof(SPCommodity))]
    [HttpDTOService(typeof(PlatformSPCommodityService))]
    public class PlatformSPCommodity : SPCommodityDTO
    {
       
    }   
}
