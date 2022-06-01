using BusinessData.ofDeliveryCenter;
using BusinessData.ofDeliveryCenter.ofDbContext;
using BusinessData.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessData.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessData.ofDeliveryCenter.ofInterface.ofPlatform;
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
    public class DeliveryCenterRepository : CenterDataRepository<DeliveryCenter>, IDeliveryCenterRepository, IEmployeeDeliveryCenterRepository, IEmployerDeliveryCenterRepository, IPlatformDeliveryCenterRepository
    {
        public DeliveryCenterRepository(DeliveryDbContext DeliveryDbContext)
            :base(DeliveryDbContext)
        {
            
        }
    }
    public class DCommodityRepository : CommodityDataRepository<DCommodity>, IDCommodityRepository, IEmployeeDCommodityRepository, IEmployerDCommodityRepository, IPlatformDCommodityRepository
    {
        public DCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
    public class SDCommodityRepository : StatusDataRepository<SDCommodity>, ISDCommodityRepository, IEmployeeSDCommodityRepository, IEmployerSDCommodityRepository, IPlatformSDCommodityRepository
    {
        public SDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
    public class MDCommodityRepository : StatusDataRepository<MDCommodity>, IMDCommodityRepository, IEmployeeMDCommodityRepository, IEmployerMDCommodityRepository, IPlatformMDCommodityRepository
    {
        public MDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
    public class EDCommodityRepository : StatusDataRepository<EDCommodity>, IEDCommodityRepository, IEmployeeEDCommodityRepository, IEmployerEDCommodityRepository, IPlatformEDCommodityRepository
    {
        public EDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
}