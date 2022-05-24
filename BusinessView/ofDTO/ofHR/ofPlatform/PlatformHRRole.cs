using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HRRole))]
    public class PlatformHRRole : PlatformEntity
    {
        [Get]public string? DetailName {get; set;}
        public string? PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter,typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}