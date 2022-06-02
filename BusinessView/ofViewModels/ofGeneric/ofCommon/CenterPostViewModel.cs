using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public class CenterPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : CenterDTO, new()
    {
        public CenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : CenterDTO, new()
    {
        public CenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : CenterDTO, new()
    {
        public CenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class CenterGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : CenterDTO, new()
    {
        public CenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}