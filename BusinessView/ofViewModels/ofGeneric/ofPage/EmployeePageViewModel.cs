using BusinessView.ofCommon.ofUser;
using BusinessView.ofCommon.ofEmployee;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric
{
    public class EmployeePageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        public EmployeePageViewModel(EmployeePostViewModel<TEntity> postViewModel, EmployeePutViewModel<TEntity> putViewModel, 
                                EmployeeDeleteViewModel<TEntity> deleteViewModel, EmployeeGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {

        }
    }
    public class EmployeePostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EmployeeEntity, new()
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}