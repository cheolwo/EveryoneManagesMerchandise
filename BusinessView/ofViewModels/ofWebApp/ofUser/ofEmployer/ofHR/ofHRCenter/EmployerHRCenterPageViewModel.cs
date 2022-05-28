using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRCenter
{
    public class EmployerHRCenterPageViewModel : EmployerCenterPageViewModel<EmployerHRCenter> 
    {
        public readonly EmployerPostHRCenterViewModel _EmployerPostHRCenterViewModel;
        public readonly EmployerPutHRCenterViewModel _EmployerPutHRCenterViewModel;
        public readonly EmployerDeleteHRCenterViewModel _EmployerDeleteHRCenterViewModel;
        public readonly EmployerGetsHRCenterViewModel _EmployerGetsHRCenterViewModel;
        public EmployerHRCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostHRCenterViewModel EmployerPostHRCenterViewModel, 
                                        EmployerPutHRCenterViewModel EmployerPutHRCenterViewModel,
                                        EmployerDeleteHRCenterViewModel EmployerDeleteHRCenterViewModel,
                                        EmployerGetsHRCenterViewModel EmployerGetsHRCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostHRCenterViewModel, EmployerPutHRCenterViewModel, EmployerDeleteHRCenterViewModel, EmployerGetsHRCenterViewModel)
                    
        {
            _EmployerPostHRCenterViewModel = EmployerPostHRCenterViewModel;
            _EmployerPutHRCenterViewModel = EmployerPutHRCenterViewModel;
            _EmployerDeleteHRCenterViewModel = EmployerDeleteHRCenterViewModel;
            _EmployerGetsHRCenterViewModel = EmployerGetsHRCenterViewModel;
        }
    }
}