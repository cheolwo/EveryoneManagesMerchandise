using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee
{
    [AutoMap(typeof(MOCommodity))]
    [HttpDTOService(typeof(EmployeeMOCommodityService))]
    public class EmployeeMOCommodity : MOCommodityDTO
    {
       
    }
}
