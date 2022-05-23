using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofProduct;
namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public class PlatformEPCommodity : PlatformEStatus
    {   
        [Many][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Many][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Many][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Many][One(ViewNameofProductCenter.MPCommodity, typeof(MPCommodity))] public string? MPCommodity {get; set;}
    }
}
