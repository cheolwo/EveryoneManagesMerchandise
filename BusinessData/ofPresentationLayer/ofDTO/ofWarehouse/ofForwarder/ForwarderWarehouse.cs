using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofForwarder
{
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderWarehouse : WarehouseDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderWCommodity : WCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderSWCommodity : SWCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderMWCommodity : MWCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderEWCommodity : EWCommodityDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderIncomingTag : IncomingTagDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderLoadFrame : LoadFrameDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderDotBarcode : DotBarcodeDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderDividedTag : DividedTagDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderWorkingdesk : WorkingDeskDTO
    {
    }
}
