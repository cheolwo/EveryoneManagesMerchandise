using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform
{
    [AutoMap(typeof(MMCommodity))]
    [HttpDTOService(typeof(EmployerMMCommodityService))]
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformMMCommodity : MMCommodityDTO
    {
        
    }
}
