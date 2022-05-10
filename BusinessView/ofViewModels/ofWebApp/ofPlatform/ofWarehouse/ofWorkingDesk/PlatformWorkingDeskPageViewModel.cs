using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse.ofWorkingDesk
{
    public class PlatformWorkingDeskPageViewModel : EntityPageViewModel<PlatformWorkingDesk> 
    {
        public PlatformWorkingDeskPageViewModel(PlatformPostWorkingDeskViewModel PlatformPostWorkingDeskViewModel, 
                                        PlatformPutWorkingDeskViewModel PlatformPutWorkingDeskViewModel,
                                        PlatformDeleteWorkingDeskViewModel PlatformDeleteWorkingDeskViewModel,
                                        PlatformGetsWorkingDeskViewModel PlatformGetsWorkingDeskViewModel)
                :base(PlatformPostWorkingDeskViewModel, PlatformPutWorkingDeskViewModel, PlatformDeleteWorkingDeskViewModel, PlatformGetsWorkingDeskViewModel)
                    
        {
            
        }
    }
}