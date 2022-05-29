using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofJournal;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity
{
    public class JCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        public JCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class JCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        public JCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class JCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        public JCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class JCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        public JCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}