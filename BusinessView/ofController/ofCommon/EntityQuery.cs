using BusinessView.ofExternal.ofCommon;
using System.Reflection;
using BusinessView.ofDTO.ofCommon;

namespace BusienssLogic.ofController.ofCommon
{
    // 그냥 매핑하는 게 더 좋아보이기는 한다.
    public class EntityQuery<DTO> where DTO : EntityDTO, new()
    {
        public DTO Dto {get; set;}
        [Query]public DateTime StartDate {get; set;}
        [Query]public DateTime EndDate {get; set;}
        public Dictionary<QueryCode, List<PropertyInfo>> GetQueryDictionary(EntityQuery<DTO> query)
        {
            return query.GetByQueryAttribute().DistributedByQueryCode();
        }
    }
    public class CenterQuery<DTO> : EntityQuery<DTO> where DTO : CenterDTO, new()
    {
    }
    public class CommodityQuery<DTO> : EntityQuery<DTO> where DTO : CommodityDTO, new()
    {
    }
    public class StatusQuery<DTO> : EntityQuery<DTO>  where DTO : StatusDTO, new()
    {
    }
}