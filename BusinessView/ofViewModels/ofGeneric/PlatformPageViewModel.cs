using BusinessView.ofCommon.ofUser;
using BusinessView.ofCommon.ofPlatform;
namespace BusinessView.ofViewModels.ofGeneric
{
    public class PlatformPageViewModel<TEntity> : PaegViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        public PlatformPageViewModel(PlatformPostViewModel<TEntity> postViewModel, PlatformPutViewModel<TEntity> putViewModel, 
                                PlatformDeleteViewModel<TEntity> deleteViewModel, PlatformGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {

        }
    }
    public class PlatformPostViewModel<TEntity> : PostViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutViewModel<TEntity> : PutViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsViewModel<TEntity> : GetsViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteViewModel<TEntity> : DeleteViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}