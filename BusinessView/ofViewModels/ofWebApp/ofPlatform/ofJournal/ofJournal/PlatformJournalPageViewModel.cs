using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJournal
{
    public class PlatformJournalPageViewModel : EntityPageViewModel<PlatformJournal> 
    {
        public PlatformJournalPageViewModel(PlatformPostJournalViewModel PlatformPostJournalViewModel, 
                                        PlatformPutJournalViewModel PlatformPutJournalViewModel,
                                        PlatformDeleteJournalViewModel PlatformDeleteJournalViewModel,
                                        PlatformGetsJournalViewModel PlatformGetsJournalViewModel)
                :base(PlatformPostJournalViewModel, PlatformPutJournalViewModel, PlatformDeleteJournalViewModel, PlatformGetsJournalViewModel)
                    
        {
            
        }
    }
}