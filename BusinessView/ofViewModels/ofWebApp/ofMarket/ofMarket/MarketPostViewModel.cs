using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket
{
    public class MarketPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : MarketDTO, new()
    {
        public MarketPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MarketPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : MarketDTO, new()
    {
        public MarketPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MarketDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : MarketDTO, new()
    {
        public MarketDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MarketGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : MarketDTO, new()
    {
        public MarketGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}