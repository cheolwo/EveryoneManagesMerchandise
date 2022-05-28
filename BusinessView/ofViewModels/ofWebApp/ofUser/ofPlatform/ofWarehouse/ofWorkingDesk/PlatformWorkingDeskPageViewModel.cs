using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWorkingDesk
{
    public class PlatformWorkingDeskPageViewModel : WorkingDeskPageViewModel<PlatformWorkingDesk> 
    {
        public readonly PlatformPostWorkingDeskViewModel _PlatformPostWorkingDeskViewModel;
        public readonly PlatformPutWorkingDeskViewModel _PlatformPutWorkingDeskViewModel;
        public readonly PlatformDeleteWorkingDeskViewModel _PlatformDeleteWorkingDeskViewModel;
        public readonly PlatformGetsWorkingDeskViewModel _PlatformGetsWorkingDeskViewModel;

        public PlatformWorkingDeskPageViewModel(PlatformPostWorkingDeskViewModel PlatformPostWorkingDeskViewModel, 
                                        PlatformPutWorkingDeskViewModel PlatformPutWorkingDeskViewModel,
                                        PlatformDeleteWorkingDeskViewModel PlatformDeleteWorkingDeskViewModel,
                                        PlatformGetsWorkingDeskViewModel PlatformGetsWorkingDeskViewModel)
                :base(PlatformPostWorkingDeskViewModel, PlatformPutWorkingDeskViewModel, PlatformDeleteWorkingDeskViewModel, PlatformGetsWorkingDeskViewModel)
                    
        {
            _PlatformPostWorkingDeskViewModel = PlatformPostWorkingDeskViewModel;
            _PlatformPutWorkingDeskViewModel = PlatformPutWorkingDeskViewModel;
            _PlatformDeleteWorkingDeskViewModel = PlatformDeleteWorkingDeskViewModel;
            _PlatformGetsWorkingDeskViewModel = PlatformGetsWorkingDeskViewModel;
        }
    }
}