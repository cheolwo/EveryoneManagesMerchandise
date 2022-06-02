using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofEmployeeRole
{
    public class EmployeeRolePostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        public EmployeeRolePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EmployeeRolePutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        public EmployeeRolePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EmployeeRoleDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        public EmployeeRoleDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class EmployeeRoleGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        public EmployeeRoleGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}