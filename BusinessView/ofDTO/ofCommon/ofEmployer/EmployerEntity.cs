using BusinessData;

namespace BusinessView.ofDTO.ofCommon.ofEmployer
{
    public class EmployerEntity : EntityDTO
    {
    }
    [AutoMap(typeof(Center))]
    public class EmployerCenter : EmployerEntity
    {
        [Get] public string? LoginId { get; set; }
        [Get] public string? Password { get; set; }
        [Get] public int FailLogin {get; set;}
        [Get] public string? Address {get; set;}
        [Get] public string? CountryCode {get; set;}
        [Detail] public string? CardNumber {get; set;}
        [Get] public string? Cvv {get; set;}
        [Get] public string? CardPassword {get; set;}
        [Get] public string? PhoneNumber {get; set;}
        [Get] public string? FaxNumber {get; set;}
        [Get][Many] public string? Commodities { get; set; }
        [Get][Many] public string? EStatuses { get; set; }
        [Get][Many] public string? MStatuses { get; set; }
        [Get][Many] public string? SStatuses { get; set; }
        [Detail][Generic(typeof(List<CenterMacAddress>))] public string? CenterMacAddresses { get; set; }
        [Detail][Generic(typeof(List<CenterIPAddress>))]public string? CenterIPAddresses { get; set; }
        [Detail][Generic(typeof(List<CenterRole>))] public string? CenterRoles {get; set;}
    }
    public class EmployerCommodity : EmployerEntity
    {
        public string? HsCode {get; set;}
        public string? OpponentBusinessUserId { get; set; }
        [Detail]public string? Barcode {get; set;}
        public string? CenterId {get; set;}
        [One][Get]public string? Center { get; set; }
        [Many][Get]public string? EStatuses { get; set; }
        [Many][Get]public string? MStatuses { get; set; }
        [Many][Get]public string? SStatuses { get; set; }
    }
    public class EmployerStatus : EmployerEntity
    {
        public string? CommodityId {get; set;}
        public string? CenterId {get; set;}
        public string? Quantity { get; set; }
        [Get][One] public string? Commodity { get; set; }
        [Get][One] public string? Center {get; set;}
    }
    public class EmployerSStatus : EmployerStatus
    {
        [Get][Many]public string? MStatuses { get; set; }
    }
    public class EmployerMStatus : EmployerStatus
    {
        [Get][One] public string? SStatus { get; set; }
        [Get][Many] public string? EStatuses { get; set; }
    }
    public class EmployerEStatus : EmployerStatus
    {
        public string? MStatusId {get; set;}
        [Get][One] public string? MStatus { get; set; }
    }
}
