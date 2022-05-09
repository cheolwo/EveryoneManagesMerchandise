using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJournalCenter
{
    public class EmployerJournalCenterPageViewModel : CenterPageViewModel<EmployerJournalCenter> 
    {
        public EmployerJournalCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostJournalCenterViewModel EmployerPostJournalCenterViewModel, 
                                        EmployerPutJournalCenterViewModel EmployerPutJournalCenterViewModel,
                                        EmployerDeleteJournalCenterViewModel EmployerDeleteJournalCenterViewModel,
                                        EmployerGetsJournalCenterViewModel EmployerGetsJournalCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostJournalCenterViewModel, EmployerPutJournalCenterViewModel, EmployerDeleteJournalCenterViewModel, EmployerGetsJournalCenterViewModel)
                    
        {
            
        }
    }
}