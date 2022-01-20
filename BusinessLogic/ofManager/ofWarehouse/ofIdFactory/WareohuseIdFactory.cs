using BusinessData.ofCommon.ofKapt;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofWarehouse.ofIdFactory
{
    public interface IWarehouseIdFactory : ICenterIdFactory<Warehouse>
    {
        Task<string> CreateByKapt(Warehouse warehouse, KAptBasicInfo kAptBasicInfo);
    }
    public class WarehouseIdFactory : CenterIdFactory<Warehouse>, IWarehouseIdFactory
    {
        public WarehouseIdFactory(IWarehouseRepository warehouseRepository)
            : base(warehouseRepository)
        {

        }
        public async Task<string> CreateByKapt(Warehouse warehouse, KAptBasicInfo kAptBasicInfo)
        {
            string Id = await base.CreateAsync(warehouse);        
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Id);
            stringBuilder.Append('-');
            stringBuilder.Append("KApt");
            stringBuilder.Append('-');
            stringBuilder.Append(kAptBasicInfo.Id);
            return stringBuilder.ToString();
        }
    }
    public interface IWCommodityIdFactory : ICommodityIdFactory<WCommodity>
    {

    }
    public class WCommodityIdFactory : CommodityIdFactory<WCommodity>, IWCommodityIdFactory
    {
        public WCommodityIdFactory(IWCommodityRepository WCommodityRepository)
            : base(WCommodityRepository)
        {

        }
    }
    public interface ISWCommodityIdFactory : IStatusIdFactory<SWCommodity>
    {

    }
    public class SWCommodityIdFactory : StatusIdFactory<SWCommodity>, ISWCommodityIdFactory
    {
        public SWCommodityIdFactory(ISWCommodityRepository SWCommodityRepository)
            : base(SWCommodityRepository)
        {

        }
    }
    public interface IMWCommodityIdFactory : IStatusIdFactory<MWCommodity>
    {

    }
    public class MWCommodityIdFactory : StatusIdFactory<MWCommodity>, IMWCommodityIdFactory
    {
        public MWCommodityIdFactory(IMWCommodityRepository MWCommodityRepository)
            : base(MWCommodityRepository)
        {

        }
    }
    public interface IEWCommodityIdFactory : IStatusIdFactory<EWCommodity>
    {

    }
    public class EWCommodityIdFactory : StatusIdFactory<EWCommodity>, IEWCommodityIdFactory
    {
        public EWCommodityIdFactory(IEWCommodityRepository EWCommodityRepository)
            : base(EWCommodityRepository)
        {

        }
    }
    public interface IWorkingDeskIdFactory : IEntityIdFactory<WorkingDesk>
    {

    }
    public class WorkingDeskIdFactory : EntityIdFactory<WorkingDesk>, IWorkingDeskIdFactory
    {
        public WorkingDeskIdFactory(IWorkingDeskRepository WorkingDeskRepository)
            : base(WorkingDeskRepository)
        {

        }
    }
    public interface IDotBarcodeIdFactory : IEntityIdFactory<DotBarcode>
    {

    }
    public class DotBarcodeIdFactory : EntityIdFactory<DotBarcode>, IDotBarcodeIdFactory
    {
        public DotBarcodeIdFactory(IDotBarcodeRepository DotBarcodeRepository)
            : base(DotBarcodeRepository)
        {

        }
    }

}