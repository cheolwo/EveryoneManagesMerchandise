using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofHRDTO.ofPlatform
{
    public class PlatformHRRole : PlatformEntity
    {
        [Get]public string DetailName {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
}