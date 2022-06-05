using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(EMCommodity))]
    [HttpDTOService(typeof(EmployeeEMCommodityService))]
    public class EmployeeEMCommodity : EMCommodityDTO
    {
        
    }
}
