using BusinessData;
using System.Text.Json;

namespace BusinessView.ofDTO.ofCommon.ofEmployee
{
    public class EmployeeEntity : EntityDTO
    {
        public IEnumerable<T> ConvertJsonToManyObject<T>(string JsonString) where T : class
        {
            IEnumerable<T>? ManyObject = JsonSerializer.Deserialize<IEnumerable<T>>(JsonString);
            return ManyObject;
        }
        public T ConvertJsonToOneObject<T>(string jsonString) where T : class
        {
            T? OneObject = JsonSerializer.Deserialize<T>(jsonString);
            return OneObject;
        }
    }
    public class EmployeeCenter : EmployeeEntity
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
        [Detail][Generic(typeof(List<CenterMacAddress>))] public List<CenterMacAddress>? CenterMacAddresses { get; set; }
        [Detail][Generic(typeof(List<CenterIPAddress>))] public List<CenterIPAddress>? CenterIPAddresses { get; set; }
        [Detail][Generic(typeof(List<CenterRole>))] public List<CenterRole>? CenterRoles {get; set;}
    }
    public class EmployeeCommodity : EmployeeEntity
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
    public class EmployeeStatus : EmployeeEntity
    {
        public string? CommodityId {get; set;}
        public string? CenterId {get; set;}
        public string? Quantity { get; set; }
        [Get][One] public string? Commodity { get; set; }
        [Get][One] public string? Center {get; set;}
    }
    public class EmployeeSStatus : EmployeeStatus
    {
        [Get][Many]public string? MStatuses { get; set; }
    }
    public class EmployeeMStatus : EmployeeStatus
    {
        [Get][One] public string? SStatus { get; set; }
        [Get][Many] public string? EStatuses { get; set; }
    }
    public class EmployeeEStatus : EmployeeStatus
    {
        public string? MStatusId {get; set;}
        [Get][One] public string? MStatus { get; set; }
    }
}
