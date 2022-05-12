using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric
{
    public class EmployerPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployerEntity, new()
    {
        public EmployerPageViewModel(EmployerPostViewModel<TEntity> postViewModel, EmployerPutViewModel<TEntity> putViewModel, 
                                EmployerDeleteViewModel<TEntity> deleteViewModel, EmployerGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {

        }
    }
    public class EmployerPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EmployerEntity, new()
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerPostViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EmployerEntity, new()
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerPutViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EmployerEntity, new()
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerGetsViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EmployerEntity, new()
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerDeleteViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
}