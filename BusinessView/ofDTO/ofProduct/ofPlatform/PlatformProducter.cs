using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public class PlatformProducter : PlatformCenter
    {
        [Detail][Many(typeof(List<ProductCenter>))]public string? ProductCenters { get; set; } 
        [Detail][Many(typeof(List<PCommodity>))]public string? PCommodities { get; set; }
        [Detail][Many(typeof(List<SPCommodity>))]public string? SPCommodities{ get; set; }
        [Detail][Many(typeof(List<MPCommdity>))]public string? MPCommodities { get; set; }    
        [Detail][Many(typeof(List<EPCommodity>))]public string? EPCommodities { get; set;}
    }
}
