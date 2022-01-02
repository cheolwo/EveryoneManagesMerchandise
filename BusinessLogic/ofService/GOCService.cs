using BusinessData.ofProduct;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder;
using BusinessLogic.ofManager.ofOrder;

namespace BusinessLogic.ofService.ofOrderer
{
    public class Orderer
    {

    }
    public class GOCService
    {
        private readonly IStatusManager<SPCommodity> _SPCommodityManager;
        private readonly IOrderCenterManager _OrderCenterManager;
        private readonly IGroupOrderCenterManager _GroupOrderCenterManager;
        public GOCService(IStatusManager<SPCommodity> sPCommodityManager, IOrderCenterManager orderCenterManager, IGroupOrderCenterManager groupOrderCenterManager)
        {
            _SPCommodityManager = sPCommodityManager;
            _OrderCenterManager = orderCenterManager;
            _GroupOrderCenterManager = groupOrderCenterManager;
        }
    }
}