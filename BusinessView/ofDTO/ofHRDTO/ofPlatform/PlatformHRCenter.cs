namespace BusinessView.ofDTO.ofHRDTO
{
    public class PlatformHRCenter : PlatformCenter
    {
        public string JournalCenterId {get; set;}
        [Get]public string BusinessNumber { get; set; }
        [Detail][Many]public string HREmployees {get; set;}
        [Detail][Many]public string EmployeeRoles {get; set;}
        [Detail][Many]public string HRRoles {get; set;}
    }
    public class HRBusinessPart : PlatformEntity
    {
        public string PartName {get; set;}
        public string PossibleAPIInfos {get; set;}
        public string HRCenter {get; set;}
    }
    public class PlatformHRRole : PlatformEntity
    {
        [Get]public string DetailName {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
    public class PlatformHREmployee : PlatformEntity
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
    public class PlatformEmployeeRole : PlatformEntity
    {
        public string HRRole {get; set;}
        public string HRBusinessPart {get; set;}
        public string HREmployee {get; set;}
        public string PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public string HRCenter {get; set;}
    }
}