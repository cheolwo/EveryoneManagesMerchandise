using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofOrderer
{
    [ActorContext(typeof(OrdererContext))]
    public class OrdererWarehouse : WarehouseDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererWCommodity : WCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererSWCommodity : SWCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererMWCommodity : MWCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererEWCommodity : EWCommodityDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererIncomingTag : IncomingTagDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererLoadFrame : LoadFrameDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererDotBarcode : DotBarcodeDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererDividedTag : DividedTagDTO
    {
    }
    [ActorContext(typeof(OrdererContext))]
    public class OrdererWorkingdesk : WorkingDeskDTO
    {
    }
}
