//using BusinessData.ofAccount.ofModel;
//using BusinessData.ofWarehouse.Model;
//using BusinessLogic.ofPipeLine.ofGeneric;

//namespace BusinessLogic.ofManager.ofWarehouse.ofPipeLine
//{
//    public interface IWarehousePipeLine : ICenterPipeLine<Warehouse, BusinessUser>, IEntityPipeLine<Warehouse, BusinessUser>
//    {

//    }
//    public class WarehousePipeLine : CenterPipeLine<Warehouse, BusinessUser>, IWarehousePipeLine
//    {
//        private readonly IWarehouseManager _warehouseManager;
//        public WarehousePipeLine(IWarehouseManager warehouseManager)
//            :base(warehouseManager)
//        {
//            _warehouseManager = warehouseManager;
//        }
//    }
//    public interface IWCommodityPipeLine : ICommodityPipeLine<WCommodity, BusinessUser>
//    {

//    }
//    public class WCommodityPipeLine : CommodityPipeLine<WCommodity, BusinessUser>, IWCommodityPipeLine
//    {

//    }
//    public interface ISWCommodityPipeLine : IStatusPipeLine<SWCommodity, BusinessUser>
//    {

//    }
//    public class SWCommodityPipeLine : StatusPipeLine<SWCommodity, BusinessUser>, ISWCommodityPipeLine
//    {

//    }
//    public interface IMWCommodityPipeLine : IStatusPipeLine<MWCommodity, BusinessUser>
//    {

//    }
//    public class MWCommodityPipeLine : StatusPipeLine<MWCommodity, BusinessUser>, IMWCommodityPipeLine
//    {

//    }
//    public interface IEWCommodityPipeLine : IStatusPipeLine<EWCommodity, BusinessUser>
//    {

//    }
//    public class EWCommodityPipeLine : StatusPipeLine<EWCommodity, BusinessUser>, IEWCommodityPipeLine
//    {

//    }
//}