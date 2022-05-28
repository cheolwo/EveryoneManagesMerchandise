using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity
{
    public class MWCommodityPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : MWCommodityDTO, new()
    {
        public MWCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MWCommodityPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : MWCommodityDTO, new()
    {
        public MWCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MWCommodityDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : MWCommodityDTO, new()
    {
        public MWCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MWCommodityGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : MWCommodityDTO, new()
    {
        public MWCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}