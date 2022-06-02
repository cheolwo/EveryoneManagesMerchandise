using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal;

namespace BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournalCenter
{
    public class JournalCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : JournalCenterDTO, new()
    {
        public JournalCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class JournalCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : JournalCenterDTO, new()
    {
        public JournalCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class JournalCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : JournalCenterDTO, new()
    {
        public JournalCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class JournalCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : JournalCenterDTO, new()
    {
        public JournalCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}