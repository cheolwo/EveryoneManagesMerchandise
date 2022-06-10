using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform
{
    [AutoMap(typeof(PlatMarket))]
    [HttpDTOService(typeof(EmployerPlatMarketService))]
    [ActorContext(typeof(PlatformSellerContext))]
    public class PlatformPlatMarket : PlatMarketDTO
    {
       
    }
}
