using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofPlatMarket
{
    public class EmployerPlatMarketPageViewModel : CenterPageViewModel<EmployerPlatMarket> 
    {
        public EmployerPlatMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostPlatMarketViewModel EmployerPostPlatMarketViewModel, 
                                        EmployerPutPlatMarketViewModel EmployerPutPlatMarketViewModel,
                                        EmployerDeletePlatMarketViewModel EmployerDeletePlatMarketViewModel,
                                        EmployerGetsPlatMarketViewModel EmployerGetsPlatMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostPlatMarketViewModel, EmployerPutPlatMarketViewModel, EmployerDeletePlatMarketViewModel, EmployerGetsPlatMarketViewModel)
                    
        {
            
        }
    }
}