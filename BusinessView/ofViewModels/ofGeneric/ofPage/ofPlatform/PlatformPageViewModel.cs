using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric
{
    public class PlatformPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : PlatformEntity, new()
    {
        public PlatformPostViewModel<TEntity> _PlatformPostViewModel { get; private set; }
        public PlatformPutViewModel<TEntity> _PlatformPutViewModel { get; private set; }
        public PlatformDeleteViewModel<TEntity> _PlatformDeleteViewModel { get; private set; }
        public PlatformGetsViewModel<TEntity> _PlatformGetsViewModel { get; private set; }
        public PlatformPageViewModel(PlatformPostViewModel<TEntity> postViewModel, PlatformPutViewModel<TEntity> putViewModel, 
                                PlatformDeleteViewModel<TEntity> deleteViewModel, PlatformGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _PlatformPostViewModel = postViewModel;
            _PlatformPutViewModel = putViewModel;  
            _PlatformGetsViewModel = getsViewModel;
            _PlatformDeleteViewModel = deleteViewModel;
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

    public class PlatformStatusPageViewModel<TEntity> : StatusPageViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        public PlatformStatusPostViewModel<TEntity> _PlatformStatusPostViewModel { get; private set; }
        public PlatformStatusPutViewModel<TEntity> _PlatformStatusPutViewModel { get; private set; }
        public PlatformStatusDeleteViewModel<TEntity> _PlatformStatusDeleteViewModel { get; private set; }
        public PlatformStatusGetsViewModel<TEntity> _PlatformStatusGetsViewModel { get; private set; }
        public PlatformStatusPageViewModel(PlatformStatusPostViewModel<TEntity> postViewModel, PlatformStatusPutViewModel<TEntity> putViewModel, 
                                PlatformStatusDeleteViewModel<TEntity> deleteViewModel, PlatformStatusGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _PlatformStatusPostViewModel = postViewModel;
            _PlatformStatusPutViewModel = putViewModel;  
            _PlatformStatusGetsViewModel = getsViewModel;
            _PlatformStatusDeleteViewModel = deleteViewModel;
        }
    }
    public class PlatformStatusPostViewModel<TEntity> : StatusPostViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformStatusPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformStatusPutViewModel<TEntity> : StatusPutViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformStatusPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformStatusGetsViewModel<TEntity> : StatusGetsViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformStatusGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformStatusDeleteViewModel<TEntity> : StatusDeleteViewModel<TEntity> where TEntity : PlatformStatus, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformStatusDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }

    public class PlatformCommodityPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : PlatformCommodity, new()
    {
        public PlatformCommodityPostViewModel<TEntity> _PlatformCommodityPostViewModel { get; private set; }
        public PlatformCommodityPutViewModel<TEntity> _PlatformCommodityPutViewModel { get; private set; }
        public PlatformCommodityDeleteViewModel<TEntity> _PlatformCommodityDeleteViewModel { get; private set; }
        public PlatformCommodityGetsViewModel<TEntity> _PlatformCommodityGetsViewModel { get; private set; }
        public PlatformCommodityPageViewModel(PlatformCommodityPostViewModel<TEntity> postViewModel, PlatformCommodityPutViewModel<TEntity> putViewModel, 
                                PlatformCommodityDeleteViewModel<TEntity> deleteViewModel, PlatformCommodityGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _PlatformCommodityPostViewModel = postViewModel;
            _PlatformCommodityPutViewModel = putViewModel;  
            _PlatformCommodityGetsViewModel = getsViewModel;
            _PlatformCommodityDeleteViewModel = deleteViewModel;
        }
    }
    public class PlatformCommodityPostViewModel<TEntity> : CommodityPostViewModel<TEntity> where TEntity : PlatformCommodity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCommodityPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCommodityPutViewModel<TEntity> : CommodityPutViewModel<TEntity> where TEntity : PlatformCommodity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCommodityPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCommodityGetsViewModel<TEntity> : CommodityGetsViewModel<TEntity> where TEntity : PlatformCommodity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCommodityGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCommodityDeleteViewModel<TEntity> : CommodityDeleteViewModel<TEntity> where TEntity : PlatformCommodity, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCommodityDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }

    public class PlatformCenterPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : PlatformCenter, new()
    {
        public PlatformCenterPostViewModel<TEntity> _PlatformCenterPostViewModel { get; private set; }
        public PlatformCenterPutViewModel<TEntity> _PlatformCenterPutViewModel { get; private set; }
        public PlatformCenterDeleteViewModel<TEntity> _PlatformCenterDeleteViewModel { get; private set; }
        public PlatformCenterGetsViewModel<TEntity> _PlatformCenterGetsViewModel { get; private set; }
        public PlatformCenterPageViewModel(PlatformCenterPostViewModel<TEntity> postViewModel, PlatformCenterPutViewModel<TEntity> putViewModel, 
                                PlatformCenterDeleteViewModel<TEntity> deleteViewModel, PlatformCenterGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _PlatformCenterPostViewModel = postViewModel;
            _PlatformCenterPutViewModel = putViewModel;  
            _PlatformCenterGetsViewModel = getsViewModel;
            _PlatformCenterDeleteViewModel = deleteViewModel;
        }
    }
    public class PlatformCenterPostViewModel<TEntity> : CenterPostViewModel<TEntity> where TEntity : PlatformCenter, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCenterPostViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCenterPutViewModel<TEntity> : CenterPutViewModel<TEntity> where TEntity : PlatformCenter, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCenterPutViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCenterGetsViewModel<TEntity> : CenterGetsViewModel<TEntity> where TEntity : PlatformCenter, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCenterGetsViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformCenterDeleteViewModel<TEntity> : CenterDeleteViewModel<TEntity> where TEntity : PlatformCenter, new()
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        public PlatformCenterDeleteViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}