using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart
{
    public class HRBusinessPartPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        public HRBusinessPartPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class HRBusinessPartPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        public HRBusinessPartPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class HRBusinessPartDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        public HRBusinessPartDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class HRBusinessPartGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        public HRBusinessPartGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}