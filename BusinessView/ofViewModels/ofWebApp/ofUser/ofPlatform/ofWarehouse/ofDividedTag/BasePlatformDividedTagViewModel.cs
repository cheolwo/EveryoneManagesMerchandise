using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformDividedTagViewModel : BaseEntityViewModel<PlatformDividedTag>
    {
        public BasePlatformDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostDividedTagViewModel : EntityPostViewModel<PlatformDividedTag>
    {
        public PlatformPostDividedTagViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutDividedTagViewModel : EntityPutViewModel<PlatformDividedTag>
    {
        public PlatformPutDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteDividedTagViewModel : EntityDeleteViewModel<PlatformDividedTag>
    {
        public PlatformDeleteDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsDividedTagViewModel : EntityGetsViewModel<PlatformDividedTag>
    {
        public PlatformGetsDividedTagViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
