using AutoMapper.Configuration.Annotations;
using BusinessData;
using BusinessLogic.ofExternal.ofSearchingService;

namespace BusinessView.ofDTO.ofCommon.ofEmployer
{
    public class EmployerEntity : EntityDTO
    {
    }
    public class EmployerCenter : EmployerEntity
    {
        [Get]/*[SourceMember(nameof(Center.LoginId))]*/ public string? LoginId { get; set; }
        [Get] public string? Password { get; set; }
        [Get] public int FailLogin {get; set;}
        [Get] [Origin(typeof(Juso))]public string? Address {get; set;}
        [Get] public string? CountryCode {get; set;}
        [Get] public string? PhoneNumber {get; set;}
        [Get] public string? FaxNumber {get; set;}
        [Get][Many(typeof(List<Commodity>))] public string? Commodities { get; set; }
        [Get][Many(typeof(List<EStatus>))] public string? EStatuses { get; set; }
        [Get][Many(typeof(List<MStatus>))] public string? MStatuses { get; set; }
        [Get][Many(typeof(List<SStatus>))] public string? SStatuses { get; set; }
        [Detail][Generic(typeof(List<CenterCard>))] public string? CenterCards { get; set; }
        [Detail][Generic(typeof(List<CenterMacAddress>))] public string? CenterMacAddresses { get; set; }
        [Detail] [Generic(typeof(List<CenterIPAddress>))]public string? CenterIPAddresses { get; set; }
        [Detail] [Generic(typeof(List<CenterRole>))]public string? CenterRoles {get; set;}
    }
    public class EmployerCommodity : EmployerEntity
    {
        public string? HsCode {get; set;}
        public string? OpponentBusinessUserId { get; set; }
        [Detail]public string? Barcode {get; set;}
        public string? CenterId {get; set;}
        [One(typeof(Center))][Get]public string? Center { get; set; }
        [Many(typeof(List<EStatus>))][Get]public string? EStatuses { get; set; }
        [Many(typeof(List<MStatus>))][Get]public string? MStatuses { get; set; }
        [Many(typeof(List<SStatus>))][Get]public string? SStatuses { get; set; }
    }
    public class EmployerStatus : EmployerEntity
    {
        public string? CommodityId {get; set;}
        public string? CenterId {get; set;}
        public string? Quantity { get; set; }
        [Get][One(typeof(Commodity))] public string? Commodity { get; set; }
        [Get][One(typeof(Center))] public string? Center {get; set;}
    }
    public class EmployerSStatus : EmployerStatus
    {
        [Get][Many(typeof(List<MStatus>))]public string? MStatuses { get; set; }
    }
    public class EmployerMStatus : EmployerStatus
    {
        [Get][One(typeof(SStatus))] public string? SStatus { get; set; }
        [Get][Many(typeof(List<EStatus>))] public string? EStatuses { get; set; }
    }
    public class EmployerEStatus : EmployerStatus
    {
        public string? MStatusId {get; set;}
        [Get][One(typeof(MStatus))] public string? MStatus { get; set; }
    }
}
