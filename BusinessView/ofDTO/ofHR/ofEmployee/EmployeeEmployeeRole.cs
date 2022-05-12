using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    public class EmployeeEmployeeRole : EmployeeEntity
    {
        public string? HRRole {get; set;}
        public string? HRBusinessPart {get; set;}
        public string? HREmployee {get; set;}
        public string? PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string? HRCenter {get; set;}
    }
}