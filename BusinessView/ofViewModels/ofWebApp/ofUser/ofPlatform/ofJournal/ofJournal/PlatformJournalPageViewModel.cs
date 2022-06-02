using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournal;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJournal
{
    public class PlatformJournalPageViewModel : JournalPageViewModel<PlatformJournal> 
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