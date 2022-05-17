using BusinessView.ofCommon.ofInterface;
using BusinessView.ofCommon.ofUser;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class BaseStatusViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : IEntityDTO, new()
    {
        public BaseStatusViewModel(ActorContext actorContext)
            :base(actorContext)
            {
                
            }
    }
    public class StatusPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : IEntityDTO, new()
    {
        public StatusPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : IEntityDTO, new()
    {
        public StatusPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : IEntityDTO, new()
    {
        public StatusDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : IEntityDTO, new()
    {
        public StatusGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}