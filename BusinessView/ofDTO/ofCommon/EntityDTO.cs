using BusinessData;
using BusinessView.ofCommon.ofInterface;
using Microsoft.AspNetCore.Components.Forms;

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
    public class EntityDTO : IEntityDTO
    {
        [Detail] public string? Id { get; set; } // 자동결정
        [Detail] public string? Code { get; set; } // 자동결정
        [Form][Get] public string? Name { get; set; }
        [Detail]public string? Container {get; set;} // 자동결정
        [Detail]public DateTime CreateTime { get; set; } // 자동결정
        [Detail]public string? UserId {get; set;} // 이 부분은 인덱스로 만들어도 괜찮겠다.
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
}