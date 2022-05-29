using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofHR;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofHRCenter
{
    public class HRCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : HRCenterDTO, new()
    {
        public HRCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class HRCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : HRCenterDTO, new()
    {
        public HRCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class HRCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : HRCenterDTO, new()
    {
        public HRCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class HRCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : HRCenterDTO, new()
    {
        public HRCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}