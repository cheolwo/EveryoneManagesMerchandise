using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofHR.ofHRRole;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class PlatformPostHRRoleViewModel : HRRolePostViewModel<PlatformHRRole>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostHRRoleViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutHRRoleViewModel : HRRolePutViewModel<PlatformHRRole>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteHRRoleViewModel : HRRoleDeleteViewModel<PlatformHRRole>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsHRRoleViewModel : HRRoleGetsViewModel<PlatformHRRole>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
