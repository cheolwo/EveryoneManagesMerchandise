using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform
{
    [AutoMap(typeof(Producter))]
    [HttpDTOService(typeof(PlatformProducterService))]
    public class PlatformProducter : ProducterDTO
    {
       
    }
}
