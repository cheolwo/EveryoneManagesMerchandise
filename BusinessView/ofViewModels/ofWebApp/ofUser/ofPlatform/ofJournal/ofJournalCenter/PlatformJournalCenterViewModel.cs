using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournalCenter;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class PlatformPostJournalCenterViewModel : JournalCenterPostViewModel<PlatformJournalCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutJournalCenterViewModel : JournalCenterPutViewModel<PlatformJournalCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteJournalCenterViewModel : JournalCenterDeleteViewModel<PlatformJournalCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsJournalCenterViewModel : JournalCenterGetsViewModel<PlatformJournalCenter>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}