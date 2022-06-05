using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(MCommodity))]
    [HttpDTOService(typeof(EmployeeMCommodityService))]
    public class EmployeeMCommodity : MCommodityDTO
    {
       
    }
}
