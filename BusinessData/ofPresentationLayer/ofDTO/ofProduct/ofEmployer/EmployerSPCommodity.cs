using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(SPCommodity))]
    [HttpDTOService(typeof(EmployerSPCommodityService))]
    public class EmployerSPCommodity : SPCommodityDTO
    {
       
    }   
}
