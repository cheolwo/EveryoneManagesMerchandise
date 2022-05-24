using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofHR;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;

namespace BusinessView.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HRBusinessPart))]
    public class PlatformHRBusinessPart : PlatformEntity
    {
        [Get]public string? PartName {get; set;}
        [Get]public string? PossibleAPIInfos {get; set;}
        [Get][One(typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}