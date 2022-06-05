using AutoMapper;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee
{
    [AutoMap(typeof(ETCommodity))]
    [HttpDTOService(typeof(EmployeeETCommodityService))]
    public class EmployeeETCommodity : ETCommodityDTO
    {
        
    }
}
