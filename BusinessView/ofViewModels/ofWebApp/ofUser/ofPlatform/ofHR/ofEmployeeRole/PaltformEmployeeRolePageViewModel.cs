using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofViewModels.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofEmployeeRole;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR.ofEmployeeRole
{
    public class PlatformEmployeeRolePageViewModel : EmployeeRolePageViewModel<PlatformEmployeeRole> 
    {
        public readonly PlatformPostEmployeeRoleViewModel _PlatformPostEmployeeRoleViewModel;
        public readonly PlatformPutEmployeeRoleViewModel _PlatformPutEmployeeRoleViewModel;
        public readonly PlatformDeleteEmployeeRoleViewModel _PlatformDeleteEmployeeRoleViewModel;
        public readonly PlatformGetsEmployeeRoleViewModel _PlatformGetsEmployeeRoleViewModel;

        public PlatformEmployeeRolePageViewModel(PlatformPostEmployeeRoleViewModel PlatformPostEmployeeRoleViewModel, 
                                        PlatformPutEmployeeRoleViewModel PlatformPutEmployeeRoleViewModel,
                                        PlatformDeleteEmployeeRoleViewModel PlatformDeleteEmployeeRoleViewModel,
                                        PlatformGetsEmployeeRoleViewModel PlatformGetsEmployeeRoleViewModel)
                :base(PlatformPostEmployeeRoleViewModel, PlatformPutEmployeeRoleViewModel, PlatformDeleteEmployeeRoleViewModel, PlatformGetsEmployeeRoleViewModel)
                    
        {
            _PlatformPostEmployeeRoleViewModel = PlatformPostEmployeeRoleViewModel;
            _PlatformPutEmployeeRoleViewModel = PlatformPutEmployeeRoleViewModel;
            _PlatformDeleteEmployeeRoleViewModel = PlatformDeleteEmployeeRoleViewModel;
            _PlatformGetsEmployeeRoleViewModel = PlatformGetsEmployeeRoleViewModel;
        }
    }
}