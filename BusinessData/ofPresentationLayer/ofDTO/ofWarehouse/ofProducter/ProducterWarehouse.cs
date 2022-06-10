using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofProducter
{
    [ActorContext(typeof(ProducterContext))]
    public class ProducterWarehouse : WarehouseDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterWCommodity : WCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterSWCommodity : SWCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterMWCommodity : MWCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterEWCommodity : EWCommodityDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterIncomingTag : IncomingTagDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterLoadFrame : LoadFrameDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterDotBarcode : DotBarcodeDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterDividedTag : DividedTagDTO
    {
    }
    [ActorContext(typeof(ProducterContext))]
    public class ProducterWorkingdesk : WorkingDeskDTO
    {
    }
}
