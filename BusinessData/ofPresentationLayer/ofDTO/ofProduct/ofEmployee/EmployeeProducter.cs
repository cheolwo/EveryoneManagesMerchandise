using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(Producter))]
    [HttpDTOService(typeof(EmployeeProducterService))]
    public class EmployeeProducter : ProducterDTO
    {
        
    }
}
