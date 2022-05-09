using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class BasePlatformJournalViewModel : BaseEntityViewModel<PlatformJournal>
    {
        public BasePlatformJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostJournalViewModel : EntityPostViewModel<PlatformJournal>
    {
        public PlatformPostJournalViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutJournalViewModel : EntityPutViewModel<PlatformJournal>
    {
        public PlatformPutJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteJournalViewModel : EntityDeleteViewModel<PlatformJournal>
    {
        public PlatformDeleteJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsJournalViewModel : EntityGetsViewModel<PlatformJournal>
    {
        public PlatformGetsJournalViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
