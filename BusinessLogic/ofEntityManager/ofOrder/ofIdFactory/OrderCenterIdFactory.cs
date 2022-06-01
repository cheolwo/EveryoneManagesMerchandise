using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofOrder.ofModel;
using BusinessData.ofOrder.ofRepository;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;

namespace BusinessLogic.ofManager.ofWarehouse.ofIdFactory
{
    public interface IOrderCenterIdFactory : ICenterIdFactory<OrderCenter>
    {

    }
    public class OrderCenterIdFactory : CenterIdFactory<OrderCenter>, IOrderCenterIdFactory
    {
        public OrderCenterIdFactory(IOrderCenterRepository OrderCenterRepository)
            : base(OrderCenterRepository)
        {

        }
    }
    public interface IOCommodityIdFactory : ICommodityIdFactory<OCommodity>
    {

    }
    public class OCommodityIdFactory : CommodityIdFactory<OCommodity>, IOCommodityIdFactory
    {
        public OCommodityIdFactory(IOCommodityRepository OCommodityRepository)
            : base(OCommodityRepository)
        {

        }
    }
    public interface ISOCommodityIdFactory : IStatusIdFactory<SOCommodity>
    {

    }
    public class SOCommodityIdFactory : StatusIdFactory<SOCommodity>, ISOCommodityIdFactory
    {
        public SOCommodityIdFactory(ISOCommodityRepository SOCommodityRepository)
            : base(SOCommodityRepository)
        {

        }
    }
    public interface IMOCommodityIdFactory : IStatusIdFactory<MOCommodity>
    {

    }
    public class MOCommodityIdFactory : StatusIdFactory<MOCommodity>, IMOCommodityIdFactory
    {
        public MOCommodityIdFactory(IMOCommodityRepository MOCommodityRepository)
            : base(MOCommodityRepository)
        {

        }
    }
    public interface IEOCommodityIdFactory : IStatusIdFactory<EOCommodity>
    {

    }
    public class EOCommodityIdFactory : StatusIdFactory<EOCommodity>, IEOCommodityIdFactory
    {
        public EOCommodityIdFactory(IEOCommodityRepository EOCommodityRepository)
            : base(EOCommodityRepository)
        {

        }
    }
}