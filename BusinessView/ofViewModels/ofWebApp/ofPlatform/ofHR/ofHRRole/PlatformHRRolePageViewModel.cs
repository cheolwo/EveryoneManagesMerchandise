using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofHRRole
{
    public class PlatformHRRolePageViewModel : EntityPageViewModel<PlatformHRRole> 
    {
        public PlatformHRRolePageViewModel(PlatformPostHRRoleViewModel PlatformPostHRRoleViewModel, 
                                        PlatformPutHRRoleViewModel PlatformPutHRRoleViewModel,
                                        PlatformDeleteHRRoleViewModel PlatformDeleteHRRoleViewModel,
                                        PlatformGetsHRRoleViewModel PlatformGetsHRRoleViewModel)
                :base(PlatformPostHRRoleViewModel, PlatformPutHRRoleViewModel, PlatformDeleteHRRoleViewModel, PlatformGetsHRRoleViewModel)
                    
        {
            
        }
    }
}