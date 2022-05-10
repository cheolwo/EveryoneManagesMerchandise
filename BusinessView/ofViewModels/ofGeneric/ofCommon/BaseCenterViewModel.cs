using BusinessView.ofCommon.ofUser;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class BaseCenterViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
        public BaseCenterViewModel(ActorContext actorContext)
            :base(actorContext)
            {
                
            }
    }
    public class CenterPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : new()
    {
        public CenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : new()
    {
        public CenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : new()
    {
        public CenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : new()
    {
        public CenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}