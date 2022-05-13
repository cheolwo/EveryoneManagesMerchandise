using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofHRDTO.ofPlatform
{
    public class PlatformHREmployee : PlatformEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
}