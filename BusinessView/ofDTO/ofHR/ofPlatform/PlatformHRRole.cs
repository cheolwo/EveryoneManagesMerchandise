using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofHR;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HRRole))]
    public class PlatformHRRole : PlatformEntity
    {
        [Query][Get]public string? DetailName {get; set;}
        [One(ViewNameofHRCenter.HRCenter,typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}