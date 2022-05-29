using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;

namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    [AutoMap(typeof(MWCommodity))]
    public class EmployeeMWCommodity : MWCommodityDTO
    {
    }
}
