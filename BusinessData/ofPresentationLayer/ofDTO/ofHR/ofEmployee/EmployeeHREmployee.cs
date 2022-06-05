using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HREmployee))]
    [HttpDTOService(typeof(EmployeeEmployeeRoleService))]
    public class EmployeeHREmployee : HREmployeeDTO
    {
        
    }
}