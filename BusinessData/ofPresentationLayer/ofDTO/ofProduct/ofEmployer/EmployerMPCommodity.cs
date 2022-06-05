using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(MPCommodity))]
    [HttpDTOService(typeof(EmployerMPCommodityService))]
    public class EmployerMPCommodity : MPCommodityDTO
    {   
  
    }
}
