using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class BasePlatformJournalCenterViewModel : BaseCenterViewModel<PlatformJournalCenter>
    {
        public BasePlatformJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostJournalCenterViewModel : CenterPostViewModel<PlatformJournalCenter>
    {
        public PlatformPostJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutJournalCenterViewModel : CenterPutViewModel<PlatformJournalCenter>
    {
        public PlatformPutJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteJournalCenterViewModel : CenterDeleteViewModel<PlatformJournalCenter>
    {
        public PlatformDeleteJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsJournalCenterViewModel : CenterGetsViewModel<PlatformJournalCenter>
    {
        public PlatformGetsJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
