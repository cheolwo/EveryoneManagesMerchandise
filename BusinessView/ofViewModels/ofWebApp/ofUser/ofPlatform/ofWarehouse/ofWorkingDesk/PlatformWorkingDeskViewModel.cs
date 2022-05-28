using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostWorkingDeskViewModel : WorkingDeskPostViewModel<PlatformWorkingDesk>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutWorkingDeskViewModel : WorkingDeskPutViewModel<PlatformWorkingDesk>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteWorkingDeskViewModel : WorkingDeskDeleteViewModel<PlatformWorkingDesk>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsWorkingDeskViewModel : WorkingDeskGetsViewModel<PlatformWorkingDesk>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsWorkingDeskViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
