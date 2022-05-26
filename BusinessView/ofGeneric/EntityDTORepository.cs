using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using BusinessView.ofDTO.ofCommon;
using System;
using BusienssView.ofExternal.ofCommon;
namespace BusinessView.ofGeneric
{
    public interface IEntityDTORepository<DTO> where DTO : EntityDTO, new()
    {

    }
    /*
        분류된 Dic을 EntityDataRepository 에 전달하는 단계
        List<Model> models = await _EntityDataRepository.QueryChaining(QueryDic, dto);
    */
    public class EntityDTORepository<DTO, Model> : EntityDataRepository<Model>, IEntityDTORepository<DTO>
                                        where DTO : EntityDTO, new() where Model : Entity, new()
    {
        private readonly List<Model> QueryModels = new();
        public EntityDTORepository(DbContext dbContext)
                :base(dbContext);
        {
            
        }
        public virtual List<Model> QueryChaining(Dictionary<QueryCode, List<PropertyInfo>> queryDic, DTO dto)
        {
            if (QueryModels.Count > 0) { QueryModels.Clear(); QueryModels = new(); }
            // QueryMatching 의 경우 Key -> ForeignKey -> Time -> String -> Int 순으로 진행된다.
            // 확장 메서드를 통해 연속적으로 진행될 수 있도록 한다.

            // Chain Code를 작성한다.
            /*
                public enum ErrorCode
                {
                    NotFound,
                    InternalServerError,
                    Unauthorised
                }
 
                public class ErrorHandler
                {
                    public int GetErrorCode(ErrorCode errorCode) =>
                        errorCode switch
                        {
                            ErrorCode.InternalServerError => 500,
                            ErrorCode.NotFound => 404,
                            ErrorCode.Unauthorised => 401,
                            _ => 500
                        };
                }
            */
        }
        public static List<Model> Query(this List<Model> list, QueryCode queryCode, 
                                            List<PropertyInfo> propertyInfo, DTO dto)
        =>  queryCode switch
        {
            QueryCode.Key => GetById((string)propertyInfo.FirstOrDefault().GetValue(dto))
        };
        private async List<Model> GetById(string id)
        {
            Model model = await base.GetByIdAsync(id);
            return QueryModels.Add(model);
        }
        
    }

}