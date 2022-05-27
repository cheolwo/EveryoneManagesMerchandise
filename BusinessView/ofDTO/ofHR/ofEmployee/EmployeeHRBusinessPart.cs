using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofHR;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HRBusinessPart))]
    public class EmployeeHRBusinessPart : HRBusinessPartDTO
    {
        
    }
}