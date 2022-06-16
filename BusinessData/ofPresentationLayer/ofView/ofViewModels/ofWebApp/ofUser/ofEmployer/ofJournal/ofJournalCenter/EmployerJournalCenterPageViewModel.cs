using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournalCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJournalCenter
{
    public class EmployerJournalCenterPageViewModel : JournalCenterPageViewModel<EmployerJournalCenter> 
    {
        public readonly EmployerPostJournalCenterViewModel _EmployerPostJournalCenterViewModel;
        public readonly EmployerPutJournalCenterViewModel _EmployerPutJournalCenterViewModel;
        public readonly EmployerDeleteJournalCenterViewModel _EmployerDeleteJournalCenterViewModel;
        public readonly EmployerGetsJournalCenterViewModel _EmployerGetsJournalCenterViewModel;

        public EmployerJournalCenterPageViewModel(EmployerPostJournalCenterViewModel EmployerPostJournalCenterViewModel, 
                                        EmployerPutJournalCenterViewModel EmployerPutJournalCenterViewModel,
                                        EmployerDeleteJournalCenterViewModel EmployerDeleteJournalCenterViewModel,
                                        EmployerGetsJournalCenterViewModel EmployerGetsJournalCenterViewModel)
                :base(EmployerPostJournalCenterViewModel, EmployerPutJournalCenterViewModel, EmployerDeleteJournalCenterViewModel, EmployerGetsJournalCenterViewModel)
                    
        {
            _EmployerPostJournalCenterViewModel = EmployerPostJournalCenterViewModel;
            _EmployerPutJournalCenterViewModel = EmployerPutJournalCenterViewModel;
            _EmployerDeleteJournalCenterViewModel = EmployerDeleteJournalCenterViewModel;
            _EmployerGetsJournalCenterViewModel = EmployerGetsJournalCenterViewModel;
        }
    }
}