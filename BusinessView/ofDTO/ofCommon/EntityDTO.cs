using BusinessView.ofCommon.ofInterface;

namespace BusinessView.ofDTO.ofCommon
{
    public class EntityDTO : IEntityDTO
    {
        [Get] public string? Id { get; set; }
        [Get] public string? Code { get; set; }
        [Get] public string? Name { get; set; }
        [Detail]public string? Container {get; set;}
        [Detail]public DateTime CreateTime { get; set; }
        [Detail]public string? UserId {get; set;} // 이 부분은 인덱스로 만들어도 괜찮겠다.
        [Detail]public List<ChangeUser>? ChangedUsers {get; set;}
        [Detail]public List<ImageofInfo>? ImageofInfos {get; set;}
        [Detail]public List<Doc>? Docs {get; set;}
        [Detail] public IDictionary<string, Stream> Files {get; set;}
    }
}