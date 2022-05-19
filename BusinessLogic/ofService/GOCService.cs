using BusinessData;
using BusinessData.ofProduct;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder;
using BusinessLogic.ofManager.ofOrder;

namespace BusinessLogic.ofService.ofOrderer
{
    public enum ServciePurpose {Get, Create, Update, Delete}
    public interface IService
    {
        int ServiceTypeChekc(IRelationable relationable, ServciePurpose purpose);
    }


    
    public class GOCService
    {
        private readonly IStatusManager<SPCommodity> _SPCommodityManager;
        private readonly IOrderCenterManager _OrderCenterManager;
        private readonly IGOCManager _GroupOrderCenterManager;
        public GOCService(IStatusManager<SPCommodity> sPCommodityManager, IOrderCenterManager orderCenterManager, IGOCManager groupOrderCenterManager)
        {
            _SPCommodityManager = sPCommodityManager;
            _OrderCenterManager = orderCenterManager;
            _GroupOrderCenterManager = groupOrderCenterManager;
        }
    }
}