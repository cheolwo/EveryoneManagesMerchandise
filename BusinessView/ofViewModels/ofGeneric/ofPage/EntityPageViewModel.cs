using System.ComponentModel;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric
{
    public class EntityPageViewModel<TEntity> where TEntity : new()
    {
        private readonly EntityPostViewModel<TEntity> _EntityPostViewModel;
        private readonly EntityPutViewModel<TEntity> _EntityPutViewModel;
        private readonly EntityDeleteViewModel<TEntity> _EntityDeleteViewModel;
        private readonly EntityGetsViewModel<TEntity> _EntityGetsViewModel;
        public event PropertyChangedEventHandler? PropertyChanged;
        public EntityPageViewModel(EntityPostViewModel<TEntity> EntityPostViewModel, EntityPutViewModel<TEntity> EntityPutViewModel,
                                            EntityDeleteViewModel<TEntity> EntityDeleteViewModel, EntityGetsViewModel<TEntity> EntityGetViewModel)
        {
            _EntityPostViewModel = EntityPostViewModel;
            _EntityPutViewModel =  EntityPutViewModel;
            _EntityDeleteViewModel = EntityDeleteViewModel;
            _EntityGetsViewModel = EntityGetViewModel;
        }
    }
    public class CenterPageViewModel<TCenter> : EntityPageViewModel<TCenter> where TCenter : new()
    {
        private readonly ICenterPageRoadAddressService _CenterPageRoadAddressService;
        private readonly ICenterPageTaxService _CenterPageTaxService;
        private readonly ICenterPageIdentityRoleService _CenterPageIdentityRoleService;
        public CenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            CenterPostViewModel<TCenter> CenterPostViewModel, 
            CenterPutViewModel<TCenter> CenterPutViewModel,
            CenterDeleteViewModel<TCenter> CenterDeleteViewModel, 
            CenterGetsViewModel<TCenter> CenterGetViewModel)
                                            :base(CenterPostViewModel, CenterPutViewModel, CenterDeleteViewModel, CenterGetViewModel)
        {
            _CenterPageIdentityRoleService = centerPageIdentityRoleService;
            _CenterPageTaxService = centerPageTaxService;
            _CenterPageRoadAddressService = centerPageRoadAddressService;
        }
    }
    public class CommodityPageViewModel<TCommodity> : EntityPageViewModel<TCommodity> where TCommodity : new()
    {
        public CommodityPageViewModel(
            CommodityPostViewModel<TCommodity> CommodityPostViewModel, 
            CommodityPutViewModel<TCommodity> CommodityPutViewModel,
            CommodityDeleteViewModel<TCommodity> CommodityDeleteViewModel, 
            CommodityGetsViewModel<TCommodity> CommodityGetViewModel)
                                            :base(CommodityPostViewModel, CommodityPutViewModel, CommodityDeleteViewModel, CommodityGetViewModel)
        {
        }
    }
    public class StatusPageViewModel<TStatus> : EntityPageViewModel<TStatus> where TStatus : new()
    {
        public StatusPageViewModel(
            StatusPostViewModel<TStatus> StatusPostViewModel, 
            StatusPutViewModel<TStatus> StatusPutViewModel,
            StatusDeleteViewModel<TStatus> StatusDeleteViewModel, 
            StatusGetsViewModel<TStatus> StatusGetViewModel)
                                            :base(StatusPostViewModel, StatusPutViewModel, StatusDeleteViewModel, StatusGetViewModel)
        {;
        }
    }
}