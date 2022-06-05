using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(PlatMarket))]
    [HttpDTOService(typeof(EmployeePlatMarketService))]
    public class EmployeePlatMarket : PlatMarketDTO
    {
        
    }
}
