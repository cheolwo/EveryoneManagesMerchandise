using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric
{
    public class EmployerPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EntityDTO, IEmployerEntity, new()
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
    public class EmployerPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : EntityDTO, IEmployerEntity, new()
    {
        public  EmployerActorContext _employerActorContext { get; private set; }
        public EmployerPostViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : EntityDTO, IEmployerEntity, new()
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerPutViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : EntityDTO, IEmployerEntity, new()
    {
        protected readonly EmployerActorContext _employerActorContext;
        public EmployerGetsViewModel(EmployerActorContext employerActorContext)
            :base(employerActorContext)
        {
            _employerActorContext = employerActorContext;
        }
    }
    public class EmployerDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : EntityDTO, IEmployerEntity, new()
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

    public class EmployerCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : EmployerCommodity, new()
    {
        public EmployerCommodityPostViewModel<TCommodity> _EmployerCommodityPostViewModel { get; private set; }
        public EmployerCommodityPutViewModel<TCommodity> _EmployerCommodityPutViewModel { get; private set; }
        public EmployerCommodityDeleteViewModel<TCommodity> _EmployerCommodityDeleteViewModel { get; private set; }
        public EmployerCommodityGetsViewModel<TCommodity> _EmployerCommodityGetsViewModel { get; private set; }
        public EmployerCommodityPageViewModel(EmployerCommodityPostViewModel<TCommodity> postViewModel, EmployerCommodityPutViewModel<TCommodity> putViewModel, 
                                EmployerCommodityDeleteViewModel<TCommodity> deleteViewModel, EmployerCommodityGetsViewModel<TCommodity> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerCommodityPostViewModel = postViewModel;
            _EmployerCommodityPutViewModel = putViewModel;  
            _EmployerCommodityGetsViewModel = getsViewModel;
            _EmployerCommodityDeleteViewModel = deleteViewModel;
        }
    }
    public class EmployerCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : EmployerCommodity, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : EmployerCommodity, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : EmployerCommodity, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : EmployerCommodity, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCommodityDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }

    public class EmployerCenterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : EmployerCenter, new()
    {
        public EmployerCenterPostViewModel<TCenter> _EmployerCenterPostViewModel { get; private set; }
        public EmployerCenterPutViewModel<TCenter> _EmployerCenterPutViewModel { get; private set; }
        public EmployerCenterDeleteViewModel<TCenter> _EmployerCenterDeleteViewModel { get; private set; }
        public EmployerCenterGetsViewModel<TCenter> _EmployerCenterGetsViewModel { get; private set; }
        public ICenterPageRoadAddressService _centerPageRoadAddressService { get; private set; }
        public ICenterPageTaxService _centerPageTaxService { get; private set; }
        public ICenterPageIdCenterRoleService _centerPageIdCenterRoleService { get; private set; }
        public EmployerCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdCenterRoleService centerPageIdCenterRoleService, 
                                        EmployerCenterPostViewModel<TCenter> postViewModel, EmployerCenterPutViewModel<TCenter> putViewModel, 
                                EmployerCenterDeleteViewModel<TCenter> deleteViewModel, EmployerCenterGetsViewModel<TCenter> getsViewModel)
            :base(postViewModel, putViewModel, deleteViewModel, getsViewModel)
        {
            _EmployerCenterPostViewModel = postViewModel;
            _EmployerCenterPutViewModel = putViewModel;  
            _EmployerCenterGetsViewModel = getsViewModel;
            _EmployerCenterDeleteViewModel = deleteViewModel;
            _centerPageIdCenterRoleService = centerPageIdCenterRoleService;
            _centerPageRoadAddressService = centerPageRoadAddressService;
            _centerPageTaxService = centerPageTaxService;
        }
    }
    public class EmployerCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : EmployerCenter, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterPostViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : EmployerCenter, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterPutViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : EmployerCenter, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterGetsViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
    public class EmployerCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : EmployerCenter, new()
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        public EmployerCenterDeleteViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
    }
}