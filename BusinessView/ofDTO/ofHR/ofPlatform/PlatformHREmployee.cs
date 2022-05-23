using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofPlatform
{
    public class PlatformHREmployee : PlatformEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string? PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string? HRCenter {get; set;}
    }
}