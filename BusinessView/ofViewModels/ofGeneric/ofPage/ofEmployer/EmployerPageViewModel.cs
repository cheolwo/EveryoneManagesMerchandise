using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric
{
    public class EmployerPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployerEntity, new()
    {
        public EmployerPostViewModel<TEntity> _EmployerPostViewModel { get; private set; }
        public EmployerPutViewModel<TEntity> _EmployerPutViewModel { get; private set; }
        public EmployerDeleteViewModel<TEntity> _EmployerDeleteViewModel { get; private set; }
        public EmployerGetsViewModel<TEntity> _EmployerGetsViewModel { get; private set; }
        public EmployerPageViewModel(EmployerPostViewModel<TEntity> postViewModel, EmployerPutViewModel<TEntity> putViewModel, 
                                EmployerDeleteViewModel<TEntity> deleteViewModel, EmployerGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerPostViewModel = postViewModel;
            _EmployerPutViewModel = putViewModel;  
            _EmployerGetsViewModel = getsViewModel;
            _EmployerDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EmployerEntity, new()
    {
        public  EmployerActorContext _employerActorContext { get; private set; }
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

    public class EmployerStatusPageViewModel<TEntity> : StatusPageViewModel<TEntity> where TEntity : EmployerStatus, new()
    {
        public EmployerStatusPostViewModel<TEntity> _EmployerStatusPostViewModel { get; private set; }
        public EmployerStatusPutViewModel<TEntity> _EmployerStatusPutViewModel { get; private set; }
        public EmployerStatusDeleteViewModel<TEntity> _EmployerStatusDeleteViewModel { get; private set; }
        public EmployerStatusGetsViewModel<TEntity> _EmployerStatusGetsViewModel { get; private set; }
        public EmployerStatusPageViewModel(EmployerStatusPostViewModel<TEntity> postViewModel, EmployerStatusPutViewModel<TEntity> putViewModel, 
                                EmployerStatusDeleteViewModel<TEntity> deleteViewModel, EmployerStatusGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerStatusPostViewModel = postViewModel;
            _EmployerStatusPutViewModel = putViewModel;  
            _EmployerStatusGetsViewModel = getsViewModel;
            _EmployerStatusDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerStatusPostViewModel<TEntity> : StatusPostViewModel<TEntity> where TEntity : EmployerStatus, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerStatusPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerStatusPutViewModel<TEntity> : StatusPutViewModel<TEntity> where TEntity : EmployerStatus, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerStatusPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerStatusGetsViewModel<TEntity> : StatusGetsViewModel<TEntity> where TEntity : EmployerStatus, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerStatusGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerStatusDeleteViewModel<TEntity> : StatusDeleteViewModel<TEntity> where TEntity : EmployerStatus, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerStatusDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }

    public class EmployerCommodityPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployerCommodity, new()
    {
        public EmployerCommodityPostViewModel<TEntity> _EmployerCommodityPostViewModel { get; private set; }
        public EmployerCommodityPutViewModel<TEntity> _EmployerCommodityPutViewModel { get; private set; }
        public EmployerCommodityDeleteViewModel<TEntity> _EmployerCommodityDeleteViewModel { get; private set; }
        public EmployerCommodityGetsViewModel<TEntity> _EmployerCommodityGetsViewModel { get; private set; }
        public EmployerCommodityPageViewModel(EmployerCommodityPostViewModel<TEntity> postViewModel, EmployerCommodityPutViewModel<TEntity> putViewModel, 
                                EmployerCommodityDeleteViewModel<TEntity> deleteViewModel, EmployerCommodityGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerCommodityPostViewModel = postViewModel;
            _EmployerCommodityPutViewModel = putViewModel;  
            _EmployerCommodityGetsViewModel = getsViewModel;
            _EmployerCommodityDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerCommodityPostViewModel<TEntity> : CommodityPostViewModel<TEntity> where TEntity : EmployerCommodity, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityPutViewModel<TEntity> : CommodityPutViewModel<TEntity> where TEntity : EmployerCommodity, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityGetsViewModel<TEntity> : CommodityGetsViewModel<TEntity> where TEntity : EmployerCommodity, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityDeleteViewModel<TEntity> : CommodityDeleteViewModel<TEntity> where TEntity : EmployerCommodity, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }

    public class EmployerCenterPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployerCenter, new()
    {
        public EmployerCenterPostViewModel<TEntity> _EmployerCenterPostViewModel { get; private set; }
        public EmployerCenterPutViewModel<TEntity> _EmployerCenterPutViewModel { get; private set; }
        public EmployerCenterDeleteViewModel<TEntity> _EmployerCenterDeleteViewModel { get; private set; }
        public EmployerCenterGetsViewModel<TEntity> _EmployerCenterGetsViewModel { get; private set; }
        public ICenterPageRoadAddressService _centerPageRoadAddressService { get; private set; }
        public ICenterPageTaxService _centerPageTaxService { get; private set; }
        public ICenterPageIdentityRoleService _centerPageIdentityRoleService { get; private set; }
        public EmployerCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService, 
                                        EmployerCenterPostViewModel<TEntity> postViewModel, EmployerCenterPutViewModel<TEntity> putViewModel, 
                                EmployerCenterDeleteViewModel<TEntity> deleteViewModel, EmployerCenterGetsViewModel<TEntity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerCenterPostViewModel = postViewModel;
            _EmployerCenterPutViewModel = putViewModel;  
            _EmployerCenterGetsViewModel = getsViewModel;
            _EmployerCenterDeleteViewModel = deleteViewModel;
            _centerPageIdentityRoleService = centerPageIdentityRoleService;
            _centerPageRoadAddressService = centerPageRoadAddressService;
            _centerPageTaxService = centerPageTaxService;
        }
    }
    public class EmployerCenterPostViewModel<TEntity> : CenterPostViewModel<TEntity> where TEntity : EmployerCenter, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterPutViewModel<TEntity> : CenterPutViewModel<TEntity> where TEntity : EmployerCenter, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterGetsViewModel<TEntity> : CenterGetsViewModel<TEntity> where TEntity : EmployerCenter, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterDeleteViewModel<TEntity> : CenterDeleteViewModel<TEntity> where TEntity : EmployerCenter, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}