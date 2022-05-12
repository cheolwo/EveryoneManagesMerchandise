using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public class PlatformEPCommodity : PlatformEStatus
    {   
        [Many][One(ViewNameofProductCenter.PCommodity)] public string? PCommodity { get; set; }
        [Many][One(ViewNameofProductCenter.ProductLand)] public string? ProductLand {get; set;}
        [Many][One(ViewNameofProductCenter.ProductCenter)] public string? Producter { get; set;}
        [Many][One(ViewNameofProductCenter.MPCommodity)] public string? MPCommodity {get; set;}
    }
}
