// using System.Collections.Generic;
// using System.Threading.Tasks;
// using BusinessData;
// using BusinessData.ofAccount.ofModel;

// namespace BusinessLogic.ofPipeLine.ofGeneric
// {
//     public class StatusPipeLine<TEntity, UEntity> : IStatusPipeLine<TEntity, UEntity>
//                                                 where TEntity : Status, IRelatedCenter, IRelatedRoles where UEntity : BusinessUser
//     {
//         public Task<TEntity> CreateAsync(TEntity entity)
//         {
//             throw new System.NotImplementedException();
//         }

//         public Task DeleteByIdAsync(string Id)
//         {
//             throw new System.NotImplementedException();
//         }

//         public Task<List<TEntity>> GetToListAsync()
//         {
//             throw new System.NotImplementedException();
//         }

//         public Task<List<TEntity>> GetToListByUserAsync(UEntity uEntity)
//         {
//             throw new System.NotImplementedException();
//         }

//         public Task<TEntity> UpdateAsync(TEntity entity)
//         {
//             throw new System.NotImplementedException();
//         }

//         public ResultofValidatedAddress ValidateAddress(PipeModel<TEntity, UEntity> model)
//         {
//             throw new System.NotImplementedException();
//         }

//         public Task<ResultofValidatedRole> ValidateRole(PipeModel<TEntity, UEntity> model)
//         {
//             throw new System.NotImplementedException();
//         }
//     }
// }