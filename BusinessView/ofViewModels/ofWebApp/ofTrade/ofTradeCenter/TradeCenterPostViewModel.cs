using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofCommon.ofTrade;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter
{
    public class TradeCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : TradeCenterDTO, new()
    {
        public TradeCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class TradeCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : TradeCenterDTO, new()
    {
        public TradeCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class TradeCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : TradeCenterDTO, new()
    {
        public TradeCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class TradeCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : TradeCenterDTO, new()
    {
        public TradeCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}