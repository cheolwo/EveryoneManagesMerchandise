using BusinessView.ofServices.ofCommon;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade.ofTradeCenter
{
    public class EmployerTradeCenterPageViewModel : CenterPageViewModel<EmployerTradeCenter> 
    {
        public EmployerTradeCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostTradeCenterViewModel EmployerPostTradeCenterViewModel, 
                                        EmployerPutTradeCenterViewModel EmployerPutTradeCenterViewModel,
                                        EmployerDeleteTradeCenterViewModel EmployerDeleteTradeCenterViewModel,
                                        EmployerGetsTradeCenterViewModel EmployerGetsTradeCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostTradeCenterViewModel, EmployerPutTradeCenterViewModel, EmployerDeleteTradeCenterViewModel, EmployerGetsTradeCenterViewModel)
                    
        {
            
        }
    }
}