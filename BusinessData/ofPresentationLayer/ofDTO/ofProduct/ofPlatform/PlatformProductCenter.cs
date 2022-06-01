using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofProduct;
namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public static class ViewNameofProductCenter
    {
        public const string ProductCenter = "ProductCenter";
        public const string PCommodity = "PCommodity";
        public const string SPCommodity = "SPCommodity";
        public const string MPCommodity = "MPCommodity";
        public const string EPCommodity =  "EPCommopdity";
        public const string ProductLand = "ProductLand";
    }
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
