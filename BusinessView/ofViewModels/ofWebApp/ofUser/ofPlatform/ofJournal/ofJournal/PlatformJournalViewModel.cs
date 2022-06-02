using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class PlatformPostJournalViewModel : JournalPostViewModel<PlatformJournal>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostJournalViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutJournalViewModel : JournalPutViewModel<PlatformJournal>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteJournalViewModel : JournalDeleteViewModel<PlatformJournal>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsJournalViewModel : JournalGetsViewModel<PlatformJournal>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
