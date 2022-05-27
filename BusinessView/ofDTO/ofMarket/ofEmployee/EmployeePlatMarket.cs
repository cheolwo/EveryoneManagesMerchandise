using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using NMemory.Data;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(PlatMarket))]
    public class EmployeePlatMarket : EmployeeCenter
    {
        
    }
}
