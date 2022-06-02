using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform
{
    public static class LandCode 
    {
        public const string Product = "Product";
        public const string LiveStock = "LiveStock";
    }
    [AutoMap(typeof(ProductCenter))]
    public class PlatformProductCenter : ProductCenterDTO
    {
        
    }
}
