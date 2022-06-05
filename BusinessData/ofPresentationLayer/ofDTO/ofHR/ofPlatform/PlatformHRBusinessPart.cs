using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HRBusinessPart))]
    [HttpDTOService(typeof(PlatformHRBusinessPartService))]
    public class PlatformHRBusinessPart : HRBusinessPartDTO
    {
       
    }
}