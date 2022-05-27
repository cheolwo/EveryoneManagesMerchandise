using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HREmployee))]
    public class EmployerHREmployee : HREmployeeDTO
    {
       
    }
}