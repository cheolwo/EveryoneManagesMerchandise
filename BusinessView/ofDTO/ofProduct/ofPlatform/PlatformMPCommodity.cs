using BusinessData;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public class PlatformMPCommodity : PlatformMStatus
    {   
        [Detail][One(ViewNameofProductCenter.PCommodity)] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public string? Producter { get; set;}
        [Detail][One(ViewNameofProductCenter.SPCommodity)] public string? SPCommodity {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity)] public string? EPCommodities {get; set;}
    }
}
