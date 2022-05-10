using BusinessView.ofCommon.ofUser;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class BaseStatusViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
        public BaseStatusViewModel(ActorContext actorContext)
            :base(actorContext)
            {
                
            }
    }
    public class StatusPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : new()
    {
        public StatusPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : new()
    {
        public StatusPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : new()
    {
        public StatusDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : new()
    {
        public StatusGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}