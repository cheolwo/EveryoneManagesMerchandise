using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(SMCommodity))]
    [HttpDTOService(typeof(EmployeeSMCommodityService))]
    public class EmployeeSMCommodity : SMCommodityDTO
    {
        
    }
}
