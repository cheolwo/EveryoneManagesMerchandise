using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(EPCommodity))]
    [HttpDTOService(typeof(EmployerEPCommodityService))]
    public class EmployerEPCommodity : EPCommodityDTO
    {   
       
    }
}
