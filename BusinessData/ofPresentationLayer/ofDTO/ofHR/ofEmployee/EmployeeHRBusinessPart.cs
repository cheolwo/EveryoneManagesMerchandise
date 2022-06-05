using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HRBusinessPart))]
    [HttpDTOService(typeof(EmployeeEmployeeRoleService))]
    public class EmployeeHRBusinessPart : HRBusinessPartDTO
    {
        
    }
}