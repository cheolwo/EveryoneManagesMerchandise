using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder.ofOrderCenter
{
    public class EmployerOrderCenterPageViewModel : EmployerCenterPageViewModel<EmployerOrderCenter> 
    {
        public readonly EmployerPostOrderCenterViewModel _EmployerPostOrderCenterViewModel;
        public readonly EmployerPutOrderCenterViewModel _EmployerPutOrderCenterViewModel;
        public readonly EmployerDeleteOrderCenterViewModel _EmployerDeleteOrderCenterViewModel;
        public readonly EmployerGetsOrderCenterViewModel _EmployerGetsOrderCenterViewModel;
        public EmployerOrderCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostOrderCenterViewModel EmployerPostOrderCenterViewModel, 
                                        EmployerPutOrderCenterViewModel EmployerPutOrderCenterViewModel,
                                        EmployerDeleteOrderCenterViewModel EmployerDeleteOrderCenterViewModel,
                                        EmployerGetsOrderCenterViewModel EmployerGetsOrderCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostOrderCenterViewModel, EmployerPutOrderCenterViewModel, EmployerDeleteOrderCenterViewModel, EmployerGetsOrderCenterViewModel)
                    
        {
            _EmployerPostOrderCenterViewModel = EmployerPostOrderCenterViewModel;
            _EmployerPutOrderCenterViewModel = EmployerPutOrderCenterViewModel;
            _EmployerDeleteOrderCenterViewModel = EmployerDeleteOrderCenterViewModel;
            _EmployerGetsOrderCenterViewModel = EmployerGetsOrderCenterViewModel;
        }
    }
}