using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournalCenter;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal.ofJournalCenter
{
    public class PlatformJournalCenterPageViewModel : JournalCenterPageViewModel<PlatformJournalCenter> 
    {
        public readonly PlatformPostJournalCenterViewModel _PlatformPostJournalCenterViewModel;
        public readonly PlatformPutJournalCenterViewModel _PlatformPutJournalCenterViewModel;
        public readonly PlatformDeleteJournalCenterViewModel _PlatformDeleteJournalCenterViewModel;
        public readonly PlatformGetsJournalCenterViewModel _PlatformGetsJournalCenterViewModel;

        public PlatformJournalCenterPageViewModel(PlatformPostJournalCenterViewModel PlatformPostJournalCenterViewModel, 
                                        PlatformPutJournalCenterViewModel PlatformPutJournalCenterViewModel,
                                        PlatformDeleteJournalCenterViewModel PlatformDeleteJournalCenterViewModel,
                                        PlatformGetsJournalCenterViewModel PlatformGetsJournalCenterViewModel)
                :base(PlatformPostJournalCenterViewModel, PlatformPutJournalCenterViewModel, PlatformDeleteJournalCenterViewModel, PlatformGetsJournalCenterViewModel)
                    
        {
            _PlatformPostJournalCenterViewModel = PlatformPostJournalCenterViewModel;
            _PlatformPutJournalCenterViewModel = PlatformPutJournalCenterViewModel;
            _PlatformDeleteJournalCenterViewModel = PlatformDeleteJournalCenterViewModel;
            _PlatformGetsJournalCenterViewModel = PlatformGetsJournalCenterViewModel;
        }
    }
}