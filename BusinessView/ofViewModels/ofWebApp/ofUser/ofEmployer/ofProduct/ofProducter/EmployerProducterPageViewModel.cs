using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofExternal.ofSearchingService;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProducter
{
    public class EmployerProducterPageViewModel : EmployerCenterPageViewModel<EmployerProducter> 
    {
        public readonly EmployerPostProducterViewModel _EmployerPostProducterViewModel;
        public readonly EmployerPutProducterViewModel _EmployerPutProducterViewModel;
        public readonly EmployerDeleteProducterViewModel _EmployerDeleteProducterViewModel;
        public readonly EmployerGetsProducterViewModel _EmployerGetsProducterViewModel;
        public EmployerProducterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostProducterViewModel EmployerPostProducterViewModel, 
                                        EmployerPutProducterViewModel EmployerPutProducterViewModel,
                                        EmployerDeleteProducterViewModel EmployerDeleteProducterViewModel,
                                        EmployerGetsProducterViewModel EmployerGetsProducterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostProducterViewModel, EmployerPutProducterViewModel, EmployerDeleteProducterViewModel, EmployerGetsProducterViewModel)
                    
        {
            _EmployerPostProducterViewModel = EmployerPostProducterViewModel;
            _EmployerPutProducterViewModel = EmployerPutProducterViewModel;
            _EmployerDeleteProducterViewModel = EmployerDeleteProducterViewModel;
            _EmployerGetsProducterViewModel = EmployerGetsProducterViewModel;
        }
    }
}