using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    public class EmployerLoadFrame : EmployerEntity
    {
        [Detail][Many(typeof(List<MWCommodity>))]public string? MWCommodities { get; set; }
        [Detail][Many(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}
