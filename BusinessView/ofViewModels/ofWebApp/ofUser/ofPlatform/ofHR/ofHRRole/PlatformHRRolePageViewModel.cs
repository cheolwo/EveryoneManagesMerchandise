using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRRole;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRRole
{
    public class PlatformHRRolePageViewModel : HRRolePageViewModel<PlatformHRRole> 
    {
        public readonly PlatformPostHRRoleViewModel _PlatformPostHRRoleViewModel;
        public readonly PlatformPutHRRoleViewModel _PlatformPutHRRoleViewModel;
        public readonly PlatformDeleteHRRoleViewModel _PlatformDeleteHRRoleViewModel;
        public readonly PlatformGetsHRRoleViewModel _PlatformGetsHRRoleViewModel;

        public PlatformHRRolePageViewModel(PlatformPostHRRoleViewModel PlatformPostHRRoleViewModel, 
                                        PlatformPutHRRoleViewModel PlatformPutHRRoleViewModel,
                                        PlatformDeleteHRRoleViewModel PlatformDeleteHRRoleViewModel,
                                        PlatformGetsHRRoleViewModel PlatformGetsHRRoleViewModel)
                :base(PlatformPostHRRoleViewModel, PlatformPutHRRoleViewModel, PlatformDeleteHRRoleViewModel, PlatformGetsHRRoleViewModel)
                    
        {
            _PlatformPostHRRoleViewModel = PlatformPostHRRoleViewModel;
            _PlatformPutHRRoleViewModel = PlatformPutHRRoleViewModel;
            _PlatformDeleteHRRoleViewModel = PlatformDeleteHRRoleViewModel;
            _PlatformGetsHRRoleViewModel = PlatformGetsHRRoleViewModel;
        }
    }
}