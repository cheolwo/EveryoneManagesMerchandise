using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofExternal.ofSearchingService;
namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJournalCenter
{
    public class EmployerJournalCenterPageViewModel : EmployerCenterPageViewModel<EmployerJournalCenter> 
    {
        public readonly EmployerPostJournalCenterViewModel _EmployerPostJournalCenterViewModel;
        public readonly EmployerPutJournalCenterViewModel _EmployerPutJournalCenterViewModel;
        public readonly EmployerDeleteJournalCenterViewModel _EmployerDeleteJournalCenterViewModel;
        public readonly EmployerGetsJournalCenterViewModel _EmployerGetsJournalCenterViewModel;
        public EmployerJournalCenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
                                        EmployerPostJournalCenterViewModel EmployerPostJournalCenterViewModel, 
                                        EmployerPutJournalCenterViewModel EmployerPutJournalCenterViewModel,
                                        EmployerDeleteJournalCenterViewModel EmployerDeleteJournalCenterViewModel,
                                        EmployerGetsJournalCenterViewModel EmployerGetsJournalCenterViewModel)
                :base(centerPageRoadAddressService, centerPageTaxService, centerPageIdentityRoleService, EmployerPostJournalCenterViewModel, EmployerPutJournalCenterViewModel, EmployerDeleteJournalCenterViewModel, EmployerGetsJournalCenterViewModel)
                    
        {
            _EmployerPostJournalCenterViewModel = EmployerPostJournalCenterViewModel;
            _EmployerPutJournalCenterViewModel = EmployerPutJournalCenterViewModel;
            _EmployerDeleteJournalCenterViewModel = EmployerDeleteJournalCenterViewModel;
            _EmployerGetsJournalCenterViewModel = EmployerGetsJournalCenterViewModel;
        }
    }
}