using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofExternal.ofCommon;
namespace BusinessView.ofDTO.ofHR
{
    public class HRCenterDTO : CenterDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? JournalCenterId {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? BusinessNumber { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<HREmployee>))]public string? HREmployees {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<EmployeeRole>))]public string? EmployeeRoles {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<HRRole>))]public string? HRRoles {get; set;}
    }   
    public class HREmployeeDTO : EntityDTO
    {
        [Query(QueryCode.Time)]public DateTime InTime {get; set;}
        [Query(QueryCode.Time)]public DateTime OutTime {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? PhoneNumber {get; set;}
        [Query(QueryCode.With)][One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string? HRCenter {get; set;}
    } 
    public class HRRoleDTO : EntityDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? DetailName {get; set;}
        [Query(QueryCode.With)][One(ViewNameofHRCenter.HRCenter,typeof(HRCenter))]public string? HRCenter {get; set;}
    }
    public class HRBusinessPartDTO : EntityDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string? PartName {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Get)][One(typeof(HRCenter))]public string? HRCenter {get; set;}
    }
    public class EmployeeRoleDTO :EntityDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(HRRole))]public string? HRRole {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(HRBusinessPart))]public string? HRBusinessPart {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(HREmployee))]public string? HREmployee {get; set;}
        [Query(QueryCode.With)][One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}