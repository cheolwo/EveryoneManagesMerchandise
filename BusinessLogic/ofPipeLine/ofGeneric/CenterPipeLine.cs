// using BusinessData;
// using BusinessData.ofAccount.ofModel;
// using BusinessLogic.ofManager.ofGeneric;

// namespace BusinessLogic.ofPipeLine.ofGeneric
// {
//     public class CenterPipeLine<TEntity, UEntity> : EntityPipeLine<TEntity, UEntity>, ICenterPipeLine<TEntity, UEntity>
//                                                 where TEntity : Center, IRelatedCenter, IRelatedRoles where UEntity : BusinessUser
//     {
//         private readonly ICenterManager<TEntity> _centerManager;
//         public CenterPipeLine(ICenterManager<TEntity> centerManager)
//             :base(centerManager)
//         {
//             _centerManager = centerManager;
//         }
//     }
// }