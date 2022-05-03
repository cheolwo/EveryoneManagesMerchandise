using BusinessData.ofProduct;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public class PlatformProducter : PlatformCenter
    {
        public ProductCenter ProductCenter { get; set; } 
        public string PCommodity { get; set; }
        public string SPCommodity { get; set; }
        public string MPCommodities { get; set; }    
        public string EPCommodity { get; set;}
    }
}
