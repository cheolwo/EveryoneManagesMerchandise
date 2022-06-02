using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal;

namespace BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournal
{
    public class JournalPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : JournalDTO, new()
    {
        public JournalPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class JournalPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : JournalDTO, new()
    {
        public JournalPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class JournalDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : JournalDTO, new()
    {
        public JournalDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class JournalGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : JournalDTO, new()
    {
        public JournalGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}