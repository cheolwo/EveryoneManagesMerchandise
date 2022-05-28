using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class BaseCommodityViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public BaseCommodityViewModel(ActorContext actorContext)
            :base(actorContext)
            {
                
            }
    }
    public class CommodityPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : CommodityDTO, new()
    {
        public CommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CommodityPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : CommodityDTO, new()
    {
        public CommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CommodityDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : CommodityDTO, new()
    {
        public CommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CommodityGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : CommodityDTO, new()
    {
        public CommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}