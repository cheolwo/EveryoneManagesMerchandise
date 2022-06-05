using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(EmployeeRole))]
    [HttpDTOService(typeof(EmployerEmployeeRoleService))]
    public class EmployerEmployeeRole : EmployeeRoleDTO
    {
        
    }
}