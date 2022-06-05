using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    public static class LandCode 
    {
        public const string Product = "Product";
        public const string LiveStock = "LiveStock";
    }
    [AutoMap(typeof(ProductCenter))]
    [HttpDTOService(typeof(EmployeeProductCenterService))]
    public class EmployeeProductCenter : ProductCenterDTO
    {
       
    }
}
