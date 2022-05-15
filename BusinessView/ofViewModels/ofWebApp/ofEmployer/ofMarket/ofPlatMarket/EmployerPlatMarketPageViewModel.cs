using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofPlatMarket
{
    public class EmployerPlatMarketPageViewModel : CenterPageViewModel<EmployerPlatMarket> 
    {
        public readonly EmployerPostPlatMarketViewModel _EmployerPostPlatMarketViewModel;
        public readonly EmployerPutPlatMarketViewModel _EmployerPutPlatMarketViewModel;
        public readonly EmployerDeletePlatMarketViewModel _EmployerDeletePlatMarketViewModel;
        public readonly EmployerGetsPlatMarketViewModel _EmployerGetsPlatMarketViewModel;
        public EmployerPlatMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostPlatMarketViewModel EmployerPostPlatMarketViewModel, 
                                        EmployerPutPlatMarketViewModel EmployerPutPlatMarketViewModel,
                                        EmployerDeletePlatMarketViewModel EmployerDeletePlatMarketViewModel,
                                        EmployerGetsPlatMarketViewModel EmployerGetsPlatMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostPlatMarketViewModel, EmployerPutPlatMarketViewModel, EmployerDeletePlatMarketViewModel, EmployerGetsPlatMarketViewModel)
                    
        {
            _EmployerPostPlatMarketViewModel = EmployerPostPlatMarketViewModel;
            _EmployerPutPlatMarketViewModel = EmployerPutPlatMarketViewModel;
            _EmployerDeletePlatMarketViewModel = EmployerDeletePlatMarketViewModel;
            _EmployerGetsPlatMarketViewModel = EmployerGetsPlatMarketViewModel;
        }
    }
}