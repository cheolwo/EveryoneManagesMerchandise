using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofProduct;
namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public class PlatformPCommodity : PlatformCommodity
    {
        [Detail]public string? Category {get; set;}
        [Detail] public string? Brand {get; set;}
        [Detail][Many(typeof(List<SPCommodity>))] public string? SPCommodities {get; set;}
        [Detail][Many(typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
        [Detail][Many(typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Detail][One(typeof(Producter))]public string? Producter {get; set;}  
    }
}
