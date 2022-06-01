using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofWarehouse;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofExternal.ofCommon;
namespace BusinessView.ofDTO.ofWarehouse.ofEmployee
{
    [AutoMap(typeof(IncomingTag))]
    public class EmployeeIncomingTag : IncomingTagDTO
    {
        
    }
}
