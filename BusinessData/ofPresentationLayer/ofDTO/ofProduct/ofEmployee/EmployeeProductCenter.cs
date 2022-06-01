using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofProduct;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofProduct.ofEmployee
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
    public class EmployeeProductCenter : ProductCenterDTO
    {
       
    }
}
