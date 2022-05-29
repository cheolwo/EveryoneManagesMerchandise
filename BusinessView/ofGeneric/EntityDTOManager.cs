using BusienssLogic.ofController.ofCommon;
using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofExternal.ofCommon;
using System.Reflection;
using System.Text;

namespace BusinessView.ofGeneric
{
    public interface IEntityDTOManager<DTO, Model> : IEntityManager<Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        Task<DTO> CreateAsync(DTO entityDTO);
        Task<DTO> UpdateAsync(DTO entityDTO);
        Task<List<DTO>> GetToListAsync(EntityQuery<DTO> entityQuery);
        Task DeleteAsync(string id);
    }
    public class EntityDTOManager<DTO, Model> : EntityManager<Model>, IEntityDTOManager<DTO, Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        private readonly IEntityDTORepository<DTO, Model> _EntityDTODataRepository;
        public EntityDTOManager(IEntityDTORepository<DTO, Model> EntityDataRepository, 
            IEntityIdFactory<Model> EntityIdFactory, 
            IEntityFileFactory<Model> entityFileFactory, 
            IEntityBlobStorage<Model> EntityBlobStorage, 
            DicConvertFactory<Model> DicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, EntityBlobStorage, DicConvertFactory)
        {
            _EntityDTODataRepository = EntityDataRepository;
        }

        public Task<DTO> CreateAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DTO>> GetToListAsync(EntityQuery<DTO> entityQuery)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DTO>> GetToListAsyncByQuery(EntityQuery<DTO> entityQuery)
        {
            // EntityQuery 를 Dictionary 로 분류하는 단계
            var QueryDic = entityQuery.GetQueryDictionary(entityQuery);
            var dto = entityQuery.Dto;
            List<DTO> dtos = new();
            // 분류된 Dic을 EntityDataRepository 에 전달하는 단계
            //List<Model> models = await _EntityDataRepository.QueryChaining(QueryDic, dto);
            //if(models != null || models.Count > 0)
            //{
            //    foreach(var model in models)
            //    {
            //        dtos.Add(model.ConvertToDTO());
            //    }
            //}
            return dtos;
        }

        public Task<DTO> UpdateAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Model> QueryChaining(Dictionary<QueryCode, List<PropertyInfo>> queryDic, EntityQuery<DTO> entityQuery)
        {
            List<Model> queryModels = new List<Model>();
            List<PropertyInfo> RemaindedQuery = new();
            List<object> Parameters = new();
            string QueryName = FindQueryName(queryDic, RemaindedQuery, Parameters, entityQuery);
            MethodInfo QueryMethod = QueryMatching(QueryName);
            queryModels = (List<Model>)QueryMethod.Invoke(_EntityDataRepository, Parameters.ToArray());
            return queryModels.FileterByRemainedQuery(RemaindedQuery, entityQuery);
        }
     
        public static MethodInfo QueryMatching(string QueryName)
        {
            var methods = typeof(EntityDTORepository<DTO, Model>).GetMethods();
            foreach(var method in methods)
            {
                if(method.Name == QueryName)
                {
                    return method;
                }
            }
            throw new ArgumentException("It is Not Exist Query Method");
        }
        // 쿼리 함수명을 자동으로 생성해주는 모듈이 필요하다.
        // 기본적으로 GetToList + By + PropertyName + Async
        // 선택여부에 따라 Related도 같이 올 수 있음 (EntityQuery 에서 오지는 않음)
        // GetToList + By + PropertyName + Related + Async
        public static string FindQueryName(Dictionary<QueryCode, List<PropertyInfo>> queryDic, 
        List<PropertyInfo> RemaindedQuery, List<object> Parameters, EntityQuery<DTO> entityQuery)
        {
            string QueryName = string.Empty;
            PropertyInfo FindPropertyInfo;
            var DicValues = queryDic.Values;
            foreach(var valuelist in DicValues)
            {
                foreach(var value  in valuelist)
                {
                    RemaindedQuery.Add(value);
                }
            }
            foreach(var key in queryDic.Keys)
            {
                if(key == QueryCode.Key)
                {
                    var props = queryDic[key];
                    if(props.Count > 0)
                    {
                        FindPropertyInfo = props.FirstOrDefault();
                        RemaindedQuery.Remove(FindPropertyInfo);
                        QueryName = CreateQueryMethodName(FindPropertyInfo.Name);
                        var parametervalue = FindPropertyInfo.GetValue(entityQuery);
                        Parameters.Add(parametervalue);
                        break;
                    }
                }
                if(key == QueryCode.ForeignKey)
                {
                    var props = queryDic[key];
                    if(props.Count > 0)
                    {
                        FindPropertyInfo = props.FirstOrDefault();
                        RemaindedQuery.Remove(FindPropertyInfo);
                        QueryName = CreateQueryMethodName(FindPropertyInfo.Name);
                        var parametervalue = FindPropertyInfo.GetValue(entityQuery);
                        Parameters.Add(parametervalue);
                        break;
                    }
                }
                if(key == QueryCode.Time)
                {
                    var props = queryDic[key];
                    FindPropertyInfo = props.FirstOrDefault();
                    RemaindedQuery.Remove(FindPropertyInfo);
                    if (props.Count > 1)
                    {
                        QueryName = CreateQueryMethodName("BetweenDateTimeAsync");
                        foreach(var prop in props)
                        {
                            var parametervalue = prop.GetValue(entityQuery);
                            Parameters.Add(parametervalue);
                        }        
                        break;
                    }
                    else
                    {
                        QueryName = CreateQueryMethodName(FindPropertyInfo.Name);
                        var parametervalue = FindPropertyInfo.GetValue(entityQuery);
                        Parameters.Add(parametervalue);
                        break;
                    }
                }
                if(key == QueryCode.String)
                {
                    var props = queryDic[key];
                    if(props.Count > 0)
                    {
                        FindPropertyInfo = props.FirstOrDefault();
                        RemaindedQuery.Remove(FindPropertyInfo);
                        QueryName = CreateQueryMethodName(FindPropertyInfo.Name);
                        Parameters[0] = FindPropertyInfo.GetValue(entityQuery);
                        break;
                    }
                }
                if(key == QueryCode.Int)
                {
                    var props = queryDic[key];
                    if(props.Count > 0)
                    {
                        FindPropertyInfo = props.FirstOrDefault();
                        RemaindedQuery.Remove(FindPropertyInfo);
                        QueryName = CreateQueryMethodName(FindPropertyInfo.Name);
                        Parameters[0] = FindPropertyInfo.GetValue(entityQuery);
                        break;
                    }
                }
            }
            return QueryName;
        }

        public static string CreateQueryMethodName(string PropertyName, bool IsGetToList=true, bool IsRelated=true)
        {
            StringBuilder stringBuilder = new();
            if(IsGetToList) { stringBuilder.Append("GetToListBy"); stringBuilder.Append(PropertyName);}
            else { stringBuilder.Append("GetBy"); stringBuilder.Append(PropertyName);}
            if(IsRelated) { stringBuilder.Append("RelatedAsync");}
            else {stringBuilder.Append("Async");}
            return stringBuilder.ToString();
        }
        // 쿼리 매칭을 하고 나머짐 쿼리 프로퍼티 요소를 통해 필터링을 하는 작업이야.
        /*
            public static double Median<T>(this IEnumerable<T> numbers, Func<T, double> selector)
                => (from num in numbers select selector(num)).Median();
        */
    }
    public static class EntityQueryFilter
    {
        public static IEnumerable<Model> Filter<Model>(this IEnumerable<Model> list, Func<Model, bool> selector) where Model : Entity
                => (from model in list where selector(model) select model).ToList();
                
        public static IEnumerable<Model> FileterByRemainedQuery<DTO, Model>(this IEnumerable<Model> Querylist, List<PropertyInfo> RemainedQuery, EntityQuery<DTO> entityQuery) where Model : Entity where DTO : EntityDTO, new()
        {
            foreach (var prop in RemainedQuery)
            {
                if (prop.Name == nameof(Entity.Code))
                {
                    Querylist = Querylist.Filter(e => e.Code.Equals(prop.GetValue(entityQuery)));
                }
                if (prop.Name == nameof(Entity.Name))
                {
                    Querylist = Querylist.Filter(e => e.Name.Equals(prop.GetValue(entityQuery)));
                }
                if (prop.Name == nameof(Entity.Container))
                {
                    Querylist = Querylist.Filter(e => e.Container.Equals(prop.GetValue(entityQuery)));
                }
                if (prop.Name == nameof(Entity.UserId))
                {
                    Querylist = Querylist.Filter(e => e.UserId.Equals(prop.GetValue(entityQuery)));
                }
                if (prop.Name == nameof(Entity.CreateTime))
                {
                    var time = (DateTime)prop.GetValue(entityQuery);
                    Querylist = Querylist.Filter(e => e.CreateTime < time);
                }
            }
            return Querylist;
        }
    }
}
