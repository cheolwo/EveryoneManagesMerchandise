using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofCommon.ofPlatform;

namespace BusinessView.ofViewModels.ofGeneric
{
    public class PlatformPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        public PlatformPageViewModel(PlatformPostViewModel<TEntity> postViewModel, PlatformPutViewModel<TEntity> putViewModel, 
                                PlatformDeleteViewModel<TEntity> deleteViewModel, PlatformGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {

        }
    }
    public class PlatformPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}