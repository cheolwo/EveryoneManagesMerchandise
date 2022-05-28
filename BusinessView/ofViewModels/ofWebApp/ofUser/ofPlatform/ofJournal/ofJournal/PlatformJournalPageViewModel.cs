using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJournal
{
    public class PlatformJournalPageViewModel : EntityPageViewModel<PlatformJournal> 
    {
        public readonly PlatformPostJournalViewModel _PlatformPostJournalViewModel;
        public readonly PlatformPutJournalViewModel _PlatformPutJournalViewModel;
        public readonly PlatformDeleteJournalViewModel _PlatformDeleteJournalViewModel;
        public readonly PlatformGetsJournalViewModel _PlatformGetsJournalViewModel;
        public PlatformJournalPageViewModel(PlatformPostJournalViewModel PlatformPostJournalViewModel, 
                                        PlatformPutJournalViewModel PlatformPutJournalViewModel,
                                        PlatformDeleteJournalViewModel PlatformDeleteJournalViewModel,
                                        PlatformGetsJournalViewModel PlatformGetsJournalViewModel)
                :base(PlatformPostJournalViewModel, PlatformPutJournalViewModel, PlatformDeleteJournalViewModel, PlatformGetsJournalViewModel)
                    
        {
            _PlatformPostJournalViewModel = PlatformPostJournalViewModel;
            _PlatformPutJournalViewModel = PlatformPutJournalViewModel;
            _PlatformDeleteJournalViewModel = PlatformDeleteJournalViewModel;
            _PlatformGetsJournalViewModel = PlatformGetsJournalViewModel;
        }
    }
}