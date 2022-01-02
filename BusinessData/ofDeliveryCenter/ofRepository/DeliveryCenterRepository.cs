using BusinessData.ofDeliveryCenter;
using BusinessData.ofDeliveryCenter.ofDbContext;
using BusinessData.ofGenericRepository;

namespace BusinessData.ofRepository
{
    public interface IDeliveryCenterRepository : ICenterDataRepository<DeliveryCenter>
    {

    }
    public interface IDCommodityRepository : ICommodityDataRepository<DCommodity>
    {

    }
    public interface ISDCommodityRepository : IStatusDataRepository<SDCommodity>
    {

    }
    public interface IMDCommodityRepository : IStatusDataRepository<MDCommodity>
    {

    }
    public interface IEDCommodityRepository : IStatusDataRepository<EDCommodity>
    {

    }
    public class DeliveryCenterRepository : CenterDataRepository<DeliveryCenter>, IDeliveryCenterRepository
    {
        public DeliveryCenterRepository(DeliveryDbContext DeliveryDbContext)
            :base(DeliveryDbContext)
        {
            
        }
    }
    public class DCommodityRepository : CommodityDataRepository<DCommodity>, IDCommodityRepository
    {
        public DCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
    public class SDCommodityRepository : StatusDataRepository<SDCommodity>, ISDCommodityRepository
    {
        public SDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
    public class MDCommodityRepository : StatusDataRepository<MDCommodity>, IMDCommodityRepository
    {
        public MDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
    public class EDCommodityRepository : StatusDataRepository<EDCommodity>, IEDCommodityRepository
    {
        public EDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
}