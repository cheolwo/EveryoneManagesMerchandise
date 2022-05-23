using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofProduct;
using BusinessData; 
namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public class PlatformProducter : PlatformCenter
    {
        [Detail][Many(typeof(List<ProductCenter>))]public string? ProductCenters { get; set; } 
        [Detail][Many(typeof(List<PCommodity>))]public string? PCommodities { get; set; }
        [Detail][Many(typeof(List<SPCommodity>))]public string? SPCommodities{ get; set; }
        [Detail][Many(typeof(List<MPCommodity>))]public string? MPCommodities { get; set; }    
        [Detail][Many(typeof(List<EPCommodity>))]public string? EPCommodities { get; set;}
    }
}
