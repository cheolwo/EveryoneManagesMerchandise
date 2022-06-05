using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform
{
    [AutoMap(typeof(ProductLand))]
    [HttpDTOService(typeof(PlatformProductLandService))]
    public class PlatformProductLand : ProductLandDTO
    {
     
    }
}
