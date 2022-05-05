using BusinessView.ofCommon.ofUser;
using BusinessView.ofCommon.ofEmployee;
namespace BusinessView.ofViewModels.ofGeneric
{
    public class EmployeePageViewModel<TEntity> : PaegViewModel<TEntity> where TEntity : EmployeeEntity
    {
        public EmployeePageViewModel(EmployeePostViewModel<TEntity> postViewModel, EmployeePutViewModel<TEntity> putViewModel, 
                                EmployeeDeleteViewModel<TEntity> deleteViewModel, EmployeeGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {

        }
    }
    public class EmployeePostViewModel<TEntity> : PostViewModel<TEntity> where TEntity : EmployeeEntity
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePostViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeePutViewModel<TEntity> : PutViewModel<TEntity> where TEntity : EmployeeEntity
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeePutViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeGetsViewModel<TEntity> : GetsViewModel<TEntity> where TEntity : EmployeeEntity
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeGetsViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
    public class EmployeeDeleteViewModel<TEntity> : DeleteViewModel<TEntity> where TEntity : EmployeeEntity
    {
        protected readonly EmployeeActorContext _EmployeeActorContext;
        public EmployeeDeleteViewModel(EmployeeActorContext EmployeeActorContext)
            :base(EmployeeActorContext)
        {
            _EmployeeActorContext = EmployeeActorContext;
        }
    }
}