using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHREmployee;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class PlatformPostHREmployeeViewModel : HREmployeePostViewModel<PlatformHREmployee>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutHREmployeeViewModel : HREmployeePutViewModel<PlatformHREmployee>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteHREmployeeViewModel : HREmployeeDeleteViewModel<PlatformHREmployee>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsHREmployeeViewModel : HREmployeeGetsViewModel<PlatformHREmployee>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsHREmployeeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
