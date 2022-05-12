using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;

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
    public class PlatformProductCenter : PlatformCenter
    {
        public string? Producters {get; set;}
        public string? CoprNumber {get; set;}
        [Detail][Many(ViewNameofProductCenter.ProductCenter)] public string? ProductLands {get; set;}
        [Detail][Many(ViewNameofProductCenter.PCommodity)] public string? PCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.SPCommodity)] public string? SPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public string? MPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity)] public string? EPCommodities {get; set;}
    }
}
