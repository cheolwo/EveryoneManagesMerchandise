using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk
{
    public class WorkingDeskPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        public WorkingDeskPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class WorkingDeskPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        public WorkingDeskPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class WorkingDeskDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        public WorkingDeskDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class WorkingDeskGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        public WorkingDeskGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}