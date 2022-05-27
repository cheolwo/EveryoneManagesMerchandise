using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofHR
{
    public class HRCenterDTO : CenterDTO
    {
        [Query][Get]public string? JournalCenterId {get; set;}
        [Query][Get]public string? BusinessNumber { get; set; }
        [Detail][Many(typeof(List<HREmployee>))]public string? HREmployees {get; set;}
        [Detail][Many(typeof(List<EmployeeRole>))]public string? EmployeeRoles {get; set;}
        [Detail][Many(typeof(List<HRRole>))]public string? HRRoles {get; set;}
    }   
    public class HREmployeeDTO : EntityDTO
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        [Query][Get]public string? PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string? HRCenter {get; set;}
    } 
    public class HRRoleDTO : EntityDTO
    {
        [Query][Get]public string? DetailName {get; set;}
        [One(ViewNameofHRCenter.HRCenter,typeof(HRCenter))]public string? HRCenter {get; set;}
    }
    public class HRBusinessPartDTO : EntityDTO
    {
        [Query][Get]public string? PartName {get; set;}
        [Query][Get]public string? PossibleAPIInfos {get; set;}
        [Get][One(typeof(HRCenter))]public string? HRCenter {get; set;}
    }
    public class EmployeeRoleDTO :EntityDTO
    {
        [Detail][One(typeof(HRRole))]public string? HRRole {get; set;}
        [Detail][One(typeof(HRBusinessPart))]public string? HRBusinessPart {get; set;}
        [Detail][One(typeof(HREmployee))]public string? HREmployee {get; set;}
        [Detail]public string? PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}