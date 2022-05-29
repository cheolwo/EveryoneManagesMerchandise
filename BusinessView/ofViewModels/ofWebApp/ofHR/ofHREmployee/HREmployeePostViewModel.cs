using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofHREmployee
{
    public class HREmployeePostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : HREmployeeDTO, new()
    {
        public HREmployeePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class HREmployeePutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : HREmployeeDTO, new()
    {
        public HREmployeePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class HREmployeeDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : HREmployeeDTO, new()
    {
        public HREmployeeDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class HREmployeeGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : HREmployeeDTO, new()
    {
        public HREmployeeGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}