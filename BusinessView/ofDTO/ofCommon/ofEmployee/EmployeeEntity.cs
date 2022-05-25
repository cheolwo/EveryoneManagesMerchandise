using BusinessData;
using BusinessLogic.ofExternal.ofSearchingService;

namespace BusinessView.ofDTO.ofCommon.ofEmployee
{
    public class EmployeeEntity : EntityDTO
    {
    }
    public class EmployeeCenter : EmployeeEntity
    {
        [Query][Get] public string? LoginId { get; set; }
        [Query][Get] public string? Password { get; set; }
        [Get] public int FailLogin {get; set;}
        [Query][Get] [Origin(typeof(Juso))]public string? Address {get; set;}
        [Query][Get] public string? CountryCode {get; set;}
        [Query][Get] public string? PhoneNumber {get; set;}
        [Query][Get] public string? FaxNumber {get; set;}
        [Get][Many(typeof(List<Commodity>))] public string? Commodities { get; set; }
        [Get][Many(typeof(List<EStatus>))] public string? EStatuses { get; set; }
        [Get][Many(typeof(List<MStatus>))] public string? MStatuses { get; set; }
        [Get][Many(typeof(List<SStatus>))] public string? SStatuses { get; set; }
        [Detail][Generic(typeof(List<CenterCard>))] public string? CenterCards { get; set; }
        [Detail][Generic(typeof(List<CenterMacAddress>))] public string? CenterMacAddresses { get; set; }
        [Detail][Generic(typeof(List<CenterIPAddress>))]public string? CenterIPAddresses { get; set; }
        [Detail][Generic(typeof(List<CenterRole>))]public string? CenterRoles {get; set;}
    }
    public class EmployeeCommodity : EmployeeEntity
    {
        [Query]public string? HsCode {get; set;}
        public string? OpponentBusinessUserId { get; set; }
        [Query][Detail]public string? Barcode {get; set;}
        [Query]public string? CenterId {get; set;}
        [One(typeof(Center))][Get]public string? Center { get; set; }
        [Many(typeof(List<EStatus>))][Get]public string? EStatuses { get; set; }
        [Many(typeof(List<MStatus>))][Get]public string? MStatuses { get; set; }
        [Many(typeof(List<SStatus>))][Get]public string? SStatuses { get; set; }
    }
    public class EmployeeStatus : EmployeeEntity
    {
        [Query]public string? CommodityId {get; set;}
        [Query]public string? CenterId {get; set;}
        [Query]public string? Quantity { get; set; }
        [Get][One(typeof(Commodity))] public string? Commodity { get; set; }
        [Get][One(typeof(Center))] public string? Center {get; set;}
    }
    public class EmployeeSStatus : EmployeeStatus
    {
        [Get][Many(typeof(List<MStatus>))]public string? MStatuses { get; set; }
    }
    public class EmployeeMStatus : EmployeeStatus
    {
        [Get][One(typeof(SStatus))] public string? SStatus { get; set; }
        [Get][Many(typeof(List<EStatus>))] public string? EStatuses { get; set; }
    }
    public class EmployeeEStatus : EmployeeStatus
    {
        public string? MStatusId {get; set;}
        [Get][One(typeof(MStatus))] public string? MStatus { get; set; }
    }
}
