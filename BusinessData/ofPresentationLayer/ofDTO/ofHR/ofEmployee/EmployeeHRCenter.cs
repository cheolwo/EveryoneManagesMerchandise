using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofHR;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HRCenter))]
    public class EmployeeHRCenter : HRCenterDTO
    {
        
    }
}