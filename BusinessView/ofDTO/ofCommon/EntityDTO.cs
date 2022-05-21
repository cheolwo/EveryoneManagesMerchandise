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
    public class EntityDTO : IEntityDTO
    {
        [Detail] public string? Id { get; set; }
        [Get] public string? Code { get; set; }
        [Get] public string? Name { get; set; }
        [Detail]public string? Container {get; set;}
        [Get]public DateTime CreateTime { get; set; }
        [Detail]public string? UserId {get; set;} // 이 부분은 인덱스로 만들어도 괜찮겠다.
        [Detail] [Generic(typeof(List<ChangeUser>))]public string? ChangedUsers {get; set;}
        [Detail] [Generic(typeof(List<ImageofInfo>))]public string? ImageofInfos {get; set;}
        [Detail] [Generic(typeof(List<Doc>))]public string? Docs {get; set;}

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