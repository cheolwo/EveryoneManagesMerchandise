//using System.Collections.Generic;
//using System.Threading.Tasks;
//using BusinessData;
//using BusinessData.ofAccount.ofModel;

//namespace BusinessLogic.ofPipeLine.ofGeneric
//{
//    public interface IEntityPipeLine<TEntity, UEntity> where TEntity : Entity, IRelatedCenter, IRelatedRoles where UEntity : BusinessUser
//    {
//        ResultofValidatedAddress ValidateAddress(PipeModel<TEntity, UEntity> model);
//        Task<ResultofValidatedRole> ValidateRole(PipeModel<TEntity, UEntity> model);
//        // Task<UEntity> GetUserByHttpContextAsync(HttpContext httpContext);
//        Task<List<TEntity>> GetToListByUserAsync(UEntity uEntity);
//        Task<TEntity> CreateAsync(TEntity entity);
//        Task<TEntity> UpdateAsync(TEntity entity);
//        Task<List<TEntity>> GetToListAsync();
//        Task DeleteByIdAsync(string Id);
//    }
//}