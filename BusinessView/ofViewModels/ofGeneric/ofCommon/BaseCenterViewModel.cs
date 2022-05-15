using BusinessView.ofCommon.ofInterface;
using BusinessView.ofCommon.ofUser;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class BaseCenterViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : class, IEntityDTO, new()
    {
        public BaseCenterViewModel(ActorContext actorContext)
            :base(actorContext)
            {
                
            }
    }
    public class CenterPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : class, IEntityDTO, new()
    {
        public CenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : class, IEntityDTO, new()
    {
        public CenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : class, IEntityDTO, new()
    {
        public CenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : class, IEntityDTO, new()
    {
        public CenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}