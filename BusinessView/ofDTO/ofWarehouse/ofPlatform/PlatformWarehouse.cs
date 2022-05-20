using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    // Generic 의 경우 DTO 에서 Json String
    /*
    Serializing to a UTF-8 byte array is about 5-10% faster than using the string-based methods. 
    The difference is because the bytes (as UTF-8) don't need to be converted to strings (UTF-16).
    To serialize to a UTF-8 byte array, call the JsonSerializer.SerializeToUtf8Bytes method:

    C#
    byte[] jsonUtf8Bytes =JsonSerializer.SerializeToUtf8Bytes(weatherForecast);
     */
    public class PlatformWarehouse : PlatformCenter
    {
        [Detail][Many(ViewNameofWarehouse.WCommodity, typeof(List<WCommodity>))] public string? WCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity))] public string? EWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public string? SWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.LoadFrame)] public string? LoadFrames { get; set; }
        [Detail][Many(ViewNameofWarehouse.DotBarcode)] public string? DotBarcodes { get; set; }
        [Detail][Many(ViewNameofWarehouse.WorkingDesk)] public string? WorkingDesks { get; set; }
        [Detail][Many(ViewNameofWarehouse.DividedTag)] public string? DividedTags { get; set; }
        [Detail][Many(ViewNameofWarehouse.IncomingTag)] public string? IncomingTags { get; set; }
    }
}
