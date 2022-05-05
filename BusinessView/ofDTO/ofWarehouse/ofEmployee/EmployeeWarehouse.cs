using BusinessData;
using BusinessView.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeWarehouse : EmployeeCenter
    {
        [Detail][Many(ViewNameofWarehouse.WCommodity)] public string? WCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public string? EWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public string? MWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public string? SWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.LoadFrame)] public string? LoadFrames { get; set; }
        [Detail][Many(ViewNameofWarehouse.DotBarcode)] public string? DotBarcodes { get; set; }
        [Detail][Many(ViewNameofWarehouse.WorkingDesk)] public string? WorkingDesks { get; set; }
        [Detail][Many(ViewNameofWarehouse.DividedTag)] public string? DividedTags { get; set; }
        [Detail][Many(ViewNameofWarehouse.IncomingTag)] public string? IncomingTags { get; set; }
    }
}
