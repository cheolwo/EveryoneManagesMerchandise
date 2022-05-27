using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofWarehouse;
using BusinessView.ofExternal.ofCommon;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(WCommodity))]
    public class EmployerWCommodity : WarehouseDTO
    {
        
    }
}
