using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class BaseCenterViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public BaseCenterViewModel(ActorContext actorContext)
            :base(actorContext)
            {
                
            }
    }
    public class CenterPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public CenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public CenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public CenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public CenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}