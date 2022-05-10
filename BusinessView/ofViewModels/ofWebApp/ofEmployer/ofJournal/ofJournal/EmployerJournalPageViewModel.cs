using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJournal
{
    public class EmployerJournalPageViewModel : EntityPageViewModel<EmployerJournal> 
    {
        public EmployerJournalPageViewModel(EmployerPostJournalViewModel EmployerPostJournalViewModel, 
                                        EmployerPutJournalViewModel EmployerPutJournalViewModel,
                                        EmployerDeleteJournalViewModel EmployerDeleteJournalViewModel,
                                        EmployerGetsJournalViewModel EmployerGetsJournalViewModel)
                :base(EmployerPostJournalViewModel, EmployerPutJournalViewModel, EmployerDeleteJournalViewModel, EmployerGetsJournalViewModel)
                    
        {
            
        }
    }
}