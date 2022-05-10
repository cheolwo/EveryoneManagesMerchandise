using BusinessView.ofCommon.ofUser;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class BaseCommodityViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
        public BaseCommodityViewModel(ActorContext actorContext)
            :base(actorContext)
            {
                
            }
    }
    public class CommodityPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : new()
    {
        public CommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CommodityPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : new()
    {
        public CommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CommodityDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : new()
    {
        public CommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CommodityGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : new()
    {
        public CommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}