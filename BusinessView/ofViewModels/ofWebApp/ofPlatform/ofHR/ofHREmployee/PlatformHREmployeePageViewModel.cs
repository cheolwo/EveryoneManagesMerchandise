using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHREmployee
{
    public class PlatformHREmployeePageViewModel : EntityPageViewModel<PlatformHREmployee> 
    {
        public PlatformHREmployeePageViewModel(PlatformPostHREmployeeViewModel PlatformPostHREmployeeViewModel, 
                                        PlatformPutHREmployeeViewModel PlatformPutHREmployeeViewModel,
                                        PlatformDeleteHREmployeeViewModel PlatformDeleteHREmployeeViewModel,
                                        PlatformGetsHREmployeeViewModel PlatformGetsHREmployeeViewModel)
                :base(PlatformPostHREmployeeViewModel, PlatformPutHREmployeeViewModel, PlatformDeleteHREmployeeViewModel, PlatformGetsHREmployeeViewModel)
                    
        {
            
        }
    }
}