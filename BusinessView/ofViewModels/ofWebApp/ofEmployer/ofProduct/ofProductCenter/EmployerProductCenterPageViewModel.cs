using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct.ofProductCenter
{
    public class EmployerProductCenterPageViewModel : CenterPageViewModel<EmployerProductCenter> 
    {
        public readonly EmployerPostProductCenterViewModel _EmployerPostProductCenterViewModel;
        public readonly EmployerPutProductCenterViewModel _EmployerPutProductCenterViewModel;
        public readonly EmployerDeleteProductCenterViewModel _EmployerDeleteProductCenterViewModel;
        public readonly EmployerGetsProductCenterViewModel _EmployerGetsProductCenterViewModel;
        public EmployerProductCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            EmployerPostProductCenterViewModel EmployerPostProductCenterViewModel, 
                                        EmployerPutProductCenterViewModel EmployerPutProductCenterViewModel,
                                        EmployerDeleteProductCenterViewModel EmployerDeleteProductCenterViewModel,
                                        EmployerGetsProductCenterViewModel EmployerGetsProductCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostProductCenterViewModel, EmployerPutProductCenterViewModel, EmployerDeleteProductCenterViewModel, EmployerGetsProductCenterViewModel)
                    
        {
            _EmployerPostProductCenterViewModel = EmployerPostProductCenterViewModel;
            _EmployerPutProductCenterViewModel = EmployerPutProductCenterViewModel;
            _EmployerDeleteProductCenterViewModel = EmployerDeleteProductCenterViewModel;
            _EmployerGetsProductCenterViewModel = EmployerGetsProductCenterViewModel;
        }
    }
}