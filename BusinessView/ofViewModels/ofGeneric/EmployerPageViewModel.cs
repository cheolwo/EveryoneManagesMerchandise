using BusinessView.ofCommon.ofUser;
using BusinessView.ofCommon.ofEmployer;
namespace BusinessView.ofViewModels.ofGeneric
{
    public class EmployerPageViewModel<TEntity> : PaegViewModel<TEntity> where TEntity : EmployerEntity
    {
        public EmployerPageViewModel(EmployerPostViewModel<TEntity> postViewModel, EmployerPutViewModel<TEntity> putViewModel, 
                                EmployerDeleteViewModel<TEntity> deleteViewModel, EmployerGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {

        }
    }
    public class EmployerPostViewModel<TEntity> : PostViewModel<TEntity> where TEntity : EmployerEntity
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerPostViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerPutViewModel<TEntity> : PutViewModel<TEntity> where TEntity : EmployerEntity
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerPutViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerGetsViewModel<TEntity> : GetsViewModel<TEntity> where TEntity : EmployerEntity
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerGetsViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerDeleteViewModel<TEntity> : DeleteViewModel<TEntity> where TEntity : EmployerEntity
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerDeleteViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
}