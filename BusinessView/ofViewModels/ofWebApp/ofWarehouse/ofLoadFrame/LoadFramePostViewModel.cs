using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame
{
    public class LoadFramePostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : LoadFrameDTO, new()
    {
        public LoadFramePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class LoadFramePutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : LoadFrameDTO, new()
    {
        public LoadFramePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class LoadFrameDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : LoadFrameDTO, new()
    {
        public LoadFrameDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class LoadFrameGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : LoadFrameDTO, new()
    {
        public LoadFrameGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}