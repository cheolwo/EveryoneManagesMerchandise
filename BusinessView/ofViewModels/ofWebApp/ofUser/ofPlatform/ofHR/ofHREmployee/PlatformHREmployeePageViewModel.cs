using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHREmployee
{
    public class PlatformHREmployeePageViewModel : EntityPageViewModel<PlatformHREmployee> 
    {
        public readonly PlatformPostHREmployeeViewModel _PlatformPostHREmployeeViewModel;
        public readonly PlatformPutHREmployeeViewModel _PlatformPutHREmployeeViewModel;
        public readonly PlatformDeleteHREmployeeViewModel _PlatformDeleteHREmployeeViewModel;
        public readonly PlatformGetsHREmployeeViewModel _PlatformGetsHREmployeeViewModel;
        public PlatformHREmployeePageViewModel(PlatformPostHREmployeeViewModel PlatformPostHREmployeeViewModel, 
                                        PlatformPutHREmployeeViewModel PlatformPutHREmployeeViewModel,
                                        PlatformDeleteHREmployeeViewModel PlatformDeleteHREmployeeViewModel,
                                        PlatformGetsHREmployeeViewModel PlatformGetsHREmployeeViewModel)
                :base(PlatformPostHREmployeeViewModel, PlatformPutHREmployeeViewModel, PlatformDeleteHREmployeeViewModel, PlatformGetsHREmployeeViewModel)
                    
        {
            _PlatformPostHREmployeeViewModel = PlatformPostHREmployeeViewModel;
            _PlatformPutHREmployeeViewModel = PlatformPutHREmployeeViewModel;
            _PlatformDeleteHREmployeeViewModel = PlatformDeleteHREmployeeViewModel;
            _PlatformGetsHREmployeeViewModel = PlatformGetsHREmployeeViewModel;
        }
    }
}