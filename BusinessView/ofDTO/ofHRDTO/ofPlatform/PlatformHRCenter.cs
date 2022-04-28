using BusinessData;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofHRDTO.ofPlatform
{
    public class PlatformHRCenter : PlatformCenter
    {
        public string JournalCenterId {get; set;}
        [Get]public string BusinessNumber { get; set; }
        [Detail][Many]public string HREmployees {get; set;}
        [Detail][Many]public string EmployeeRoles {get; set;}
        [Detail][Many]public string HRRoles {get; set;}
    }
}