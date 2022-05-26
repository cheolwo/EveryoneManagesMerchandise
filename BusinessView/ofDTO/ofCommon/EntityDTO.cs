using BusinessData;
using BusinessView.ofCommon.ofInterface;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

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
        public QueryAttribute()
        {

        }
    }
    public class EntityDTO : IEntityDTO
    {
        [Key][Query][Detail] public string? Id { get; set; } // 자동결정
        [Query][Detail] public string? Code { get; set; } // 자동결정
        [Query][Form][Get] public string? Name { get; set; }
        [Query][Detail]public string? Container {get; set;} // 자동결정
        [Query][Detail]public DateTime CreateTime { get; set; } // 자동결정
        [Query][Detail]public string? UserId {get; set;} // 이 부분은 인덱스로 만들어도 괜찮겠다.
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

    }
    public class CommodityDTO : EntityDTO
    {

    }
    public class StatusDTO : EntityDTO
    {

    }
}