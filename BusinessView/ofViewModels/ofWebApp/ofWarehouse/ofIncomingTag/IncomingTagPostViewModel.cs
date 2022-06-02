using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag
{
    public class IncomingTagPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : IncomingTagDTO, new()
    {
        public IncomingTagPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class IncomingTagPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : IncomingTagDTO, new()
    {
        public IncomingTagPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class IncomingTagDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : IncomingTagDTO, new()
    {
        public IncomingTagDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class IncomingTagGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : IncomingTagDTO, new()
    {
        public IncomingTagGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}