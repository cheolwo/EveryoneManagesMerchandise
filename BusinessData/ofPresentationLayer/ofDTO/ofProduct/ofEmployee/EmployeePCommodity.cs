using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(PCommodity))]
    [HttpDTOService(typeof(EmployeePCommodityService))]
    public class EmployeePCommodity : PCommodityDTO
    {
       
    }
}
