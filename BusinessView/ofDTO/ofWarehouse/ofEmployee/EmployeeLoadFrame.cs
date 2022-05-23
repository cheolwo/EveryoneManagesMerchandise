using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    public class EmployeeLoadFrame : EmployeeEntity
    {
        [Detail][Many(typeof(List<MCommodity>))]public string? MWCommodities { get; set; }
        [Detail][Many(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}
