using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HRRole))]
    [HttpDTOService(typeof(PlatformHRRoleService))]
    public class PlatformHRRole : HRRoleDTO
    {
        
    }
}