using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofGroupOrder;
using BusinessData.ofGroupOrder.ofModel;
using BusinessData;

namespace BusinessView.ofDTO.ofGroupOrder.ofEmployee
{
    [AutoMap(typeof(GOC))]
    public class EmployeeGOC : EmployeeCenter
    {
        public string? OrderCenters { get; set; }
        public string? WarehouseId { get; set; }
    }
}
