using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofHR
{
    public class BasePlatformHRRoleViewModel : BaseEntityViewModel<PlatformHRRole>
    {
        public BasePlatformHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostHRRoleViewModel : EntityPostViewModel<PlatformHRRole>
    {
        public PlatformPostHRRoleViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutHRRoleViewModel : EntityPutViewModel<PlatformHRRole>
    {
        public PlatformPutHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteHRRoleViewModel : EntityDeleteViewModel<PlatformHRRole>
    {
        public PlatformDeleteHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsHRRoleViewModel : EntityGetsViewModel<PlatformHRRole>
    {
        public PlatformGetsHRRoleViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
