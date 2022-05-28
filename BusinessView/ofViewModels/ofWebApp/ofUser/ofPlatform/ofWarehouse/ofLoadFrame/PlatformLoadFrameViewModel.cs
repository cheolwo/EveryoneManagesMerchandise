using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostLoadFrameViewModel : LoadFramePostViewModel<PlatformLoadFrame>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutLoadFrameViewModel : LoadFramePutViewModel<PlatformLoadFrame>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteLoadFrameViewModel : LoadFrameDeleteViewModel<PlatformLoadFrame>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsLoadFrameViewModel : LoadFrameGetsViewModel<PlatformLoadFrame>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsLoadFrameViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
