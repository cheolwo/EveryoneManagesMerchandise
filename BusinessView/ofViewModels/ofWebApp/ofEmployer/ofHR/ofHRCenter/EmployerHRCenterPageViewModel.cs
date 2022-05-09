using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofHR.ofHRCenter
{
    public class EmployerHRCenterPageViewModel : CenterPageViewModel<EmployerHRCenter> 
    {
        public EmployerHRCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostHRCenterViewModel EmployerPostHRCenterViewModel, 
                                        EmployerPutHRCenterViewModel EmployerPutHRCenterViewModel,
                                        EmployerDeleteHRCenterViewModel EmployerDeleteHRCenterViewModel,
                                        EmployerGetsHRCenterViewModel EmployerGetsHRCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostHRCenterViewModel, EmployerPutHRCenterViewModel, EmployerDeleteHRCenterViewModel, EmployerGetsHRCenterViewModel)
                    
        {
            
        }
    }
}