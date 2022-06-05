using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(ProductLand))]
    [HttpDTOService(typeof(EmployeeProductLandService))]
    public class EmployeeProductLand : ProductLandDTO
    {
    }
}
