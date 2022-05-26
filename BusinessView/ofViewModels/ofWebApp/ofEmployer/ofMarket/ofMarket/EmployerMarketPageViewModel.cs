using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket.ofMarket
{
    public class EmployerMarketPageViewModel : EmployerCenterPageViewModel<EmployerMarket> 
    {
        public readonly EmployerPostMarketViewModel _EmployerPostMarketViewModel;
        public readonly EmployerPutMarketViewModel _EmployerPutMarketViewModel;
        public readonly EmployerDeleteMarketViewModel _EmployerDeleteMarketViewModel;
        public readonly EmployerGetsMarketViewModel _EmployerGetsMarketViewModel;
        public EmployerMarketPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostMarketViewModel EmployerPostMarketViewModel, 
                                        EmployerPutMarketViewModel EmployerPutMarketViewModel,
                                        EmployerDeleteMarketViewModel EmployerDeleteMarketViewModel,
                                        EmployerGetsMarketViewModel EmployerGetsMarketViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostMarketViewModel, EmployerPutMarketViewModel, EmployerDeleteMarketViewModel, EmployerGetsMarketViewModel)
                    
        {
            _EmployerPostMarketViewModel = EmployerPostMarketViewModel;
            _EmployerPutMarketViewModel = EmployerPutMarketViewModel;
            _EmployerDeleteMarketViewModel = EmployerDeleteMarketViewModel;
            _EmployerGetsMarketViewModel = EmployerGetsMarketViewModel;
        }
    }
}