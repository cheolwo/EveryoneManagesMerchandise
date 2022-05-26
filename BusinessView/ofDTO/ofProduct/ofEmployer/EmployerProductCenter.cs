using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofProduct;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofProduct.ofEmployer
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
    public class EmployerProductCenter : EmployerCenter
    {
        [Query][Get]public string? CoprNumber {get; set;}
        [Detail][Many(typeof(List<Producter>))]public string? Producters {get; set;}
        [Detail][Many(ViewNameofProductCenter.ProductCenter, typeof(List<ProductLand>))] public string? ProductLands {get; set;}
        [Detail][Many(ViewNameofProductCenter.PCommodity, typeof(List<PCommodity>))] public string? PCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.SPCommodity, typeof(List<SPCommodity>))] public string? SPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity, typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity, typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
    }
}
