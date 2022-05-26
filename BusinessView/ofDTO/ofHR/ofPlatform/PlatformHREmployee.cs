using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofHR;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HREmployee))]
    public class PlatformHREmployee : PlatformEntity
    {
        [Query]public DateTime InTime {get; set;}
        [Query]public DateTime OutTime {get; set;}
        [Query]public string? PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}