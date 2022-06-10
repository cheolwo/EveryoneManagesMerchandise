using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofForwarder
{
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderTradeCenter : TradeCenterDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderTCommodity : TCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderSTCommodity : STCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderMTCommodity : MTCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderETCommodity : ETCommodityDTO
    {
    }
}
