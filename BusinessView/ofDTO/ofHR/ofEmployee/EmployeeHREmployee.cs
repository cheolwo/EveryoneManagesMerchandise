using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofHR;
using BusinessView.ofDTO.ofHR;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HREmployee))]
    public class EmployeeHREmployee : HREmployeeDTO
    {
        
    }
}