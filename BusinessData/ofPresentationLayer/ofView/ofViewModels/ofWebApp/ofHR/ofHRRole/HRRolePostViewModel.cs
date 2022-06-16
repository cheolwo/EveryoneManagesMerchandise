using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofHRRole
{
    public class HRRolePostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : HRRoleDTO, new()
    {
        public HRRolePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class HRRolePutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : HRRoleDTO, new()
    {
        public HRRolePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class HRRoleDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : HRRoleDTO, new()
    {
        public HRRoleDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class HRRoleGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : HRRoleDTO, new()
    {
        public HRRoleGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}