using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofOrder.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofModel
{
    [Relation(typeof(EOCommodity), nameof(EOCommodity))]
    [DataContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    public class EOCommodity : EStatus
    {
        public int OutgoingQuantity { get; set; } // 출고수량
        public MOCommodity MOCommodity { get; set; }
        public OCommodity OCommodity { get; set; }
        public OrderCenter OrderCenter { get; set; }
    }
}
