using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    [AutoMap(typeof(Warehouse))]
    public class EmployeeWarehouse : EmployeeCenter
    {
        [Detail][Many(ViewNameofWarehouse.WCommodity, typeof(List<WCommodity>))] public string? WCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity, typeof(List<SWCommodity>))] public string? SWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.LoadFrame, typeof(List<LoadFrame>))] public string? LoadFrames { get; set; }
        [Detail][Many(ViewNameofWarehouse.DotBarcode, typeof(List<DotBarcode>))] public string? DotBarcodes { get; set; }
        [Detail][Many(ViewNameofWarehouse.WorkingDesk, typeof(List<WorkingDesk>))] public string? WorkingDesks { get; set; }
        [Detail][Many(ViewNameofWarehouse.DividedTag, typeof(List<DividedTag>))] public string? DividedTags { get; set; }
        [Detail][Many(ViewNameofWarehouse.IncomingTag, typeof(List<IncomingTag>))] public string? IncomingTags { get; set; }
    }
}
