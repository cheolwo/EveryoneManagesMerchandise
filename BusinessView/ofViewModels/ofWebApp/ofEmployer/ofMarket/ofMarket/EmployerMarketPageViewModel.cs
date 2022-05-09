using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMarket
{
    public class EmployerMarketPageViewModel : CenterPageViewModel<EmployerMarket> 
    {
        public EmployerMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostMarketViewModel EmployerPostMarketViewModel, 
                                        EmployerPutMarketViewModel EmployerPutMarketViewModel,
                                        EmployerDeleteMarketViewModel EmployerDeleteMarketViewModel,
                                        EmployerGetsMarketViewModel EmployerGetsMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostMarketViewModel, EmployerPutMarketViewModel, EmployerDeleteMarketViewModel, EmployerGetsMarketViewModel)
                    
        {
            
        }
    }
}