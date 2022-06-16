using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDividedTag
{
    public class DividedTagPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : DividedTagDTO, new()
    {
        public DividedTagPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class DividedTagPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : DividedTagDTO, new()
    {
        public DividedTagPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class DividedTagDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : DividedTagDTO, new()
    {
        public DividedTagDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class DividedTagGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : DividedTagDTO, new()
    {
        public DividedTagGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}