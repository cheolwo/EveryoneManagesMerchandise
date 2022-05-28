using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofMarket;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket
{
    public class PlatMarketPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : PlatMarketDTO, new()
    {
        public PlatMarketPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class PlatMarketPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : PlatMarketDTO, new()
    {
        public PlatMarketPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class PlatMarketDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : PlatMarketDTO, new()
    {
        public PlatMarketDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class PlatMarketGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : PlatMarketDTO, new()
    {
        public PlatMarketGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}