using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class BaseStatusViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public BaseStatusViewModel(ActorContext actorContext)
            :base(actorContext)
            {
                
            }
    }
    public class StatusPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public StatusPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public StatusPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public StatusDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public StatusGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}