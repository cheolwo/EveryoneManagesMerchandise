using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofPlatform
{
    public class PlatformHRBusinessPart : PlatformEntity
    {
        public string? PartName {get; set;}
        public string? PossibleAPIInfos {get; set;}
        public string? HRCenter {get; set;}
    }
}