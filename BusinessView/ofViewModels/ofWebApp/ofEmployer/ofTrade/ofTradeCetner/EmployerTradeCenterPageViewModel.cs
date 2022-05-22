using BusinessView.ofServices.ofCommon;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;
using BusinessLogic.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofTradeCenter
{
    public class EmployerTradeCenterPageViewModel : EmployerCenterPageViewModel<EmployerTradeCenter> 
    {
        public readonly EmployerPostTradeCenterViewModel _EmployerPostTradeCenterViewModel;
        public readonly EmployerPutTradeCenterViewModel _EmployerPutTradeCenterViewModel;
        public readonly EmployerDeleteTradeCenterViewModel _EmployerDeleteTradeCenterViewModel;
        public readonly EmployerGetsTradeCenterViewModel _EmployerGetsTradeCenterViewModel;
        public EmployerTradeCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostTradeCenterViewModel EmployerPostTradeCenterViewModel, 
                                        EmployerPutTradeCenterViewModel EmployerPutTradeCenterViewModel,
                                        EmployerDeleteTradeCenterViewModel EmployerDeleteTradeCenterViewModel,
                                        EmployerGetsTradeCenterViewModel EmployerGetsTradeCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostTradeCenterViewModel, EmployerPutTradeCenterViewModel, EmployerDeleteTradeCenterViewModel, EmployerGetsTradeCenterViewModel)
                    
        {
            _EmployerPostTradeCenterViewModel = EmployerPostTradeCenterViewModel;
            _EmployerPutTradeCenterViewModel = EmployerPutTradeCenterViewModel;
            _EmployerDeleteTradeCenterViewModel = EmployerDeleteTradeCenterViewModel;
            _EmployerGetsTradeCenterViewModel = EmployerGetsTradeCenterViewModel;
        }
    }
}