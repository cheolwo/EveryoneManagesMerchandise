using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofMarket.ofPlatform
{
    public class PlatformPlatMarket : PlatformCenter
    {
        [Get]public string NameofPlatForm {get; set;}
        [Get]public string VendorId { get; set; }
        [Get]public string VendorPassword {get; set;}
        [Detail]public byte[] AccessKey { get; set; }
        [Detail]public byte[] SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity)] public string PMMCommodities {get; set;}
    }
}
