using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofHR.ofPlatform
{
    public class PlatformEmployeeRole : PlatformEntity
    {
        public string? HRRole {get; set;}
        public string? HRBusinessPart {get; set;}
        public string? HREmployee {get; set;}
        public string? PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string? HRCenter {get; set;}
    }
}