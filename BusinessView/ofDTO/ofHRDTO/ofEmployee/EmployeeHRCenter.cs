using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofHRDTO.ofEmployee
{
    public class EmployeeHRCenter : EmployeeCenter
    {
        public string JournalCenterId {get; set;}
        [Get]public string BusinessNumber { get; set; }
        [Detail][Many]public string HREmployees {get; set;}
        [Detail][Many]public string EmployeeRoles {get; set;}
        [Detail][Many]public string HRRoles {get; set;}
    }
    public class HRBusinessPart : EmployeeEntity
    {
        public string PartName {get; set;}
        public string PossibleAPIInfos {get; set;}
        public string HRCenter {get; set;}
    }
    public class EmployeeHRRole : EmployeeEntity
    {
        [Get]public string DetailName {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
    public class EmployeeHREmployee : EmployeeEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
    public class EmployeeEmployeeRole : EmployeeEntity
    {
        public string HRRole {get; set;}
        public string HRBusinessPart {get; set;}
        public string HREmployee {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
}