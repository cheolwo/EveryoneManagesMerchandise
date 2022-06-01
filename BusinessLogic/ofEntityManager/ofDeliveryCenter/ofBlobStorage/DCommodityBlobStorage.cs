using BusinessData.ofDeliveryCenter;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage
{
    public interface IDCommodityBlobContainerFactory : IEntityContainerFactory<DCommodity>
    {

    }
    public interface ISDCommodityBlobContainerFactory : IEntityContainerFactory<SDCommodity>
    {

    }
    public interface IMDCommodityBlobContainerFactory : IEntityContainerFactory<MDCommodity>
    {

    }
    public interface IEDCommodityBlobContainerFactory : IEntityContainerFactory<EDCommodity>
    {

    }
    public interface IDeliveryCenterBlobContainerFactory : IEntityContainerFactory<DeliveryCenter>
    {

    }
    public interface IDCommodityBlobStorage : IEntityBlobStorage<DCommodity>
    {

    }
    public interface ISDCommodityBlobStorage : IEntityBlobStorage<SDCommodity>
    {

    }
    public interface IMDCommodityBlobStorage : IEntityBlobStorage<MDCommodity>
    {

    }
    public interface IEDCommodityBlobStorage : IEntityBlobStorage<EDCommodity>
    {

    }
    public interface IDeliveryCenterBlobStorage : IEntityBlobStorage<DeliveryCenter>
    {

    }
    public class DCommodityBlobStorage : EntityBlobStorage<DCommodity>, IDCommodityBlobStorage
    {
        public DCommodityBlobStorage(IDCommodityBlobContainerFactory dCommodityBlobContainerFactory)
            :base(dCommodityBlobContainerFactory)
        {

        }
    }
    public class SDCommodityBlobStorage : EntityBlobStorage<SDCommodity>, ISDCommodityBlobStorage
    {
        public SDCommodityBlobStorage(ISDCommodityBlobContainerFactory SDCommodityBlobContainerFactory)
            :base(SDCommodityBlobContainerFactory)
        {

        }

    }
    public class MDCommodityBlobStorage : EntityBlobStorage<MDCommodity>, IMDCommodityBlobStorage
    {
        public MDCommodityBlobStorage(IMDCommodityBlobContainerFactory MDCommodityBlobContainerFactory)
            :base(MDCommodityBlobContainerFactory)
        {

        }
    }
    public class EDCommodityBlobStorage : EntityBlobStorage<EDCommodity>, IEDCommodityBlobStorage
    {
        public EDCommodityBlobStorage(IEDCommodityBlobContainerFactory EDCommodityBlobContainerFactory)
            :base(EDCommodityBlobContainerFactory)
        {

        }
    }
    public class DeliveryCenterBlobStorage : EntityBlobStorage<DeliveryCenter>, IDeliveryCenterBlobStorage
    {
        public DeliveryCenterBlobStorage(IDeliveryCenterBlobContainerFactory DeliveryCenterBlobContainerFactory)
            :base(DeliveryCenterBlobContainerFactory)
        {

        }
    }
}