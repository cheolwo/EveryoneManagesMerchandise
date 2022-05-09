using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofEmployeeRole
{
    public class PlatformEmployeeRolePageViewModel : EntityPageViewModel<PlatformEmployeeRole> 
    {
        public PlatformEmployeeRolePageViewModel(PlatformPostEmployeeRoleViewModel PlatformPostEmployeeRoleViewModel, 
                                        PlatformPutEmployeeRoleViewModel PlatformPutEmployeeRoleViewModel,
                                        PlatformDeleteEmployeeRoleViewModel PlatformDeleteEmployeeRoleViewModel,
                                        PlatformGetsEmployeeRoleViewModel PlatformGetsEmployeeRoleViewModel)
                :base(PlatformPostEmployeeRoleViewModel, PlatformPutEmployeeRoleViewModel, PlatformDeleteEmployeeRoleViewModel, PlatformGetsEmployeeRoleViewModel)
                    
        {
            
        }
    }
}