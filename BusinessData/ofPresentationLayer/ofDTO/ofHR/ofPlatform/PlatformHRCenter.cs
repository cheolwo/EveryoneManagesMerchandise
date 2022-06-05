using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HRCenter))]
    [HttpDTOService(typeof(PlatformHRCenterService))]
    public class PlatformHRCenter : HRCenterDTO
    {
        
    }
}