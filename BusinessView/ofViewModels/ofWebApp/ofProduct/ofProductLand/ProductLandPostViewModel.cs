using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductLand
{
    public class ProductLandPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : ProductLandDTO, new()
    {
        public ProductLandPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class ProductLandPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : ProductLandDTO, new()
    {
        public ProductLandPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class ProductLandDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : ProductLandDTO, new()
    {
        public ProductLandDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class ProductLandGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : ProductLandDTO, new()
    {
        public ProductLandGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}