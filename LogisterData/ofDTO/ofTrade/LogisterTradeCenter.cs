using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofLogister
{
    [ActorContext(typeof(LogisterContext))]
    public class LogisterTradeCenter : TradeCenterDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterTCommodity : TCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterSTCommodity : STCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterMTCommodity : MTCommodityDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterETCommodity : ETCommodityDTO
    {
    }
}
