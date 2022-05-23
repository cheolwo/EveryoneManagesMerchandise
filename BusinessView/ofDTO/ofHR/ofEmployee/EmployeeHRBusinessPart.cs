using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    public class EmployeeHRBusinessPart : EmployeeEntity
    {
        public string? PartName {get; set;}
        public string? PossibleAPIInfos {get; set;}
        public string? HRCenter {get; set;}
    }
}