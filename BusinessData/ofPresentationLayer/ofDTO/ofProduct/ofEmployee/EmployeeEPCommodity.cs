using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(EPCommodity))]
    [HttpDTOService(typeof(EmployeeEPCommodityService))]
    public class EmployeeEPCommodity : EPCommodityDTO
    {   
       
    }
}
