using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;
using BusinessView.ofExternal.ofCommon;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    [AutoMap(typeof(WCommodity))]
    public class EmployeeWCommodity : WCommodityDTO
    {
        
    }
}
