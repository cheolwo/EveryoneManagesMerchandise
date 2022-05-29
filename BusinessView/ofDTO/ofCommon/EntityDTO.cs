using BusinessData;
using BusinessView.ofCommon.ofInterface;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using BusinessView.ofExternal.ofCommon;
using BusinessView.ofExternal.ofSearchingService;

namespace BusinessView.ofDTO.ofCommon
{
    public static class InitializedValue
    {
        public const string InitializedStringValue = "Null";
        public const int InitializedIntValue = 0;
    }
    public class FormAttribute : Attribute
    {
        public FormAttribute()
        {
            
        }
    }
    public class QueryAttribute : Attribute
    {
        private QueryCode queryCode;
        public QueryAttribute(QueryCode code)
        {
            queryCode = code;
        }
        public QueryCode QueryCode
        {
            get => queryCode;
        }
    }
    public class EntityDTO 
    {
        [Query(QueryCode.Key)][Detail] public string? Id { get; set; } // 자동결정
        [Query(QueryCode.String)][Detail] public string? Code { get; set; } // 자동결정
        [Query(QueryCode.String)][Form][Get] public string? Name { get; set; }
        [Query(QueryCode.String)][Detail]public string? Container {get; set;} // 자동결정
        [Query(QueryCode.Time)][Detail]public DateTime CreateTime { get; set; } // 자동결정
        [Query(QueryCode.String)][Detail]public string? UserId {get; set;} // 이 부분은 인덱스로 만들어도 괜찮겠다.
        [Detail] [Generic(typeof(List<ChangeUser>))]public string? ChangedUsers {get; set;} // 자동결정
        [Detail] [Generic(typeof(List<ImageofInfo>))]public string? ImageofInfos {get; set;} // 자동결정
        [Detail] [Generic(typeof(List<Doc>))]public string? Docs {get; set;} // 자동결정

        public void BrowserFileToDTO(IList<IBrowserFile> files, EntityDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public bool EqualsById(object obj)
        {
            throw new NotImplementedException();
        }
    }
    public class CenterDTO : EntityDTO
    {
        [Query(QueryCode.String)][Get] public string? LoginId { get; set; }
        [Query(QueryCode.String)][Get] public string? Password { get; set; }
        [Get] public int FailLogin {get; set;}
        [Query(QueryCode.String)][Get] [Origin(typeof(Juso))]public string? Address {get; set;}
        [Query(QueryCode.String)][Get] public string? CountryCode {get; set;}
        [Query(QueryCode.String)][Get] public string? PhoneNumber {get; set;}
        [Query(QueryCode.String)][Get] public string? FaxNumber {get; set;}
        [Query(QueryCode.With)][Get][Many(typeof(List<Commodity>))] public string? Commodities { get; set; }
        [Query(QueryCode.With)][Get][Many(typeof(List<EStatus>))] public string? EStatuses { get; set; }
        [Query(QueryCode.With)][Get][Many(typeof(List<MStatus>))] public string? MStatuses { get; set; }
        [Query(QueryCode.With)][Get][Many(typeof(List<SStatus>))] public string? SStatuses { get; set; }
        [Detail][Generic(typeof(List<CenterCard>))] public string? CenterCards { get; set; }
        [Detail][Generic(typeof(List<CenterMacAddress>))] public string? CenterMacAddresses { get; set; }
        [Detail][Generic(typeof(List<CenterIPAddress>))]public string? CenterIPAddresses { get; set; }
        [Detail][Generic(typeof(List<CenterRole>))]public string? CenterRoles {get; set;}
    }
    public class CommodityDTO : EntityDTO
    {
        [Query(QueryCode.String)]public string? HsCode {get; set;}
        public string? OpponentBusinessUserId { get; set; }
        [Query(QueryCode.String)][Detail]public string? Barcode {get; set;}
        [Query(QueryCode.ForeignKey)]public string? CenterId {get; set;}
        [Query(QueryCode.With)][One(typeof(Center))][Get]public string? Center { get; set; }
        [Query(QueryCode.With)][Many(typeof(List<EStatus>))][Get]public string? EStatuses { get; set; }
        [Query(QueryCode.With)][Many(typeof(List<MStatus>))][Get]public string? MStatuses { get; set; }
        [Query(QueryCode.With)][Many(typeof(List<SStatus>))][Get]public string? SStatuses { get; set; }
    }
    public class StatusDTO : EntityDTO
    {
        [Query(QueryCode.ForeignKey)]public string? CommodityId {get; set;}
        [Query(QueryCode.ForeignKey)]public string? CenterId {get; set;}
        [Query(QueryCode.Int)]public string? Quantity { get; set; }
        [Query(QueryCode.With)] public string? Commodity { get; set; }
        [Query(QueryCode.With)] public string? Center {get; set;}
    }
    public class SStatusDTO : StatusDTO
    {
        [Query(QueryCode.With)][Get][Many(typeof(List<MStatus>))]public string? MStatuses { get; set; }
    }
    public class MStatusDTO : StatusDTO
    {
        [Query(QueryCode.ForeignKey)]public string SStatusId {get; set;}
        [Query(QueryCode.With)][Get][One(typeof(SStatus))] public string? SStatus { get; set; }
        [Query(QueryCode.With)][Get][Many(typeof(List<EStatus>))] public string? EStatuses { get; set; }
    }
    public class EStatusDTO : StatusDTO
    {
        [Query(QueryCode.ForeignKey)]public string? MStatusId {get; set;}
        [Query(QueryCode.With)][Get][One(typeof(MStatus))] public string? MStatus { get; set; }
    }
}