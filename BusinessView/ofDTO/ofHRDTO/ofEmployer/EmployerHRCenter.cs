using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofHRDTO
{
    public class EmployerHRCenter : EmployerCenter
    {
        public string JournalCenterId {get; set;}
        [Get]public string BusinessNumber { get; set; }
        [Detail][Many]public string HREmployees {get; set;}
        [Detail][Many]public string EmployeeRoles {get; set;}
        [Detail][Many]public string HRRoles {get; set;}
    }
    public class HRBusinessPart : EmployerEntity
    {
        public string PartName {get; set;}
        public string PossibleAPIInfos {get; set;}
        public string HRCenter {get; set;}
    }
    public class EmployerHRRole : EmployerEntity
    {
        [Get]public string DetailName {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
    public class EmployerHREmployee : EmployerEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
    public class EmployerEmployeeRole : EmployerEntity
    {
        public string HRRole {get; set;}
        public string HRBusinessPart {get; set;}
        public string HREmployee {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
}