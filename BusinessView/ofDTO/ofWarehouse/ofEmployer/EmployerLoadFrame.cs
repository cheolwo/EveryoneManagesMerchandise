using BusinessView.ofDTO.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    public class EmployerLoadFrame : EmployerEntity
    {
        [Detail][Many(typeof(List<MCommodity>))]public string? MWCommodities { get; set; }
        [Detail][Many(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}
