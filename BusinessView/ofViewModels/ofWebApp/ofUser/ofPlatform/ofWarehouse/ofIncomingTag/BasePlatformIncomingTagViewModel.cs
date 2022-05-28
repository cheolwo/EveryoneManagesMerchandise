using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformIncomingTagViewModel : BaseEntityViewModel<PlatformIncomingTag>
    {
        public BasePlatformIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostIncomingTagViewModel : EntityPostViewModel<PlatformIncomingTag>
    {
        public PlatformPostIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutIncomingTagViewModel : EntityPutViewModel<PlatformIncomingTag>
    {
        public PlatformPutIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteIncomingTagViewModel : EntityDeleteViewModel<PlatformIncomingTag>
    {
        public PlatformDeleteIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsIncomingTagViewModel : EntityGetsViewModel<PlatformIncomingTag>
    {
        public PlatformGetsIncomingTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
