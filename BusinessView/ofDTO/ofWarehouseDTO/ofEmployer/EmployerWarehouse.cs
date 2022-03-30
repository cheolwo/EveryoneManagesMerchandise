using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofCommon.ofEmployee;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofWarehouse.ofEmployer
{
    public class EmployerWarehouse : EmployerCenter
    {
        [Detail][Many(ViewNameofWarehouse.WCommodity)] public List<WCommodity> WCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public List<EWCommodity> EWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public List<MWCommodity> MWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public List<SWCommodity> SWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.LoadFrame)] public List<LoadFrame> LoadFrames { get; set; }
        [Detail][Many(ViewNameofWarehouse.DotBarcode)] public List<DotBarcode> DotBarcodes {get; set;}
        [Detail][Many(ViewNameofWarehouse.WorkingDesk)] public List<WorkingDesk> WorkingDesks {get; set;}
        [Detail][Many(ViewNameofWarehouse.DividedTag)] public List<DividedTag> DividedTags {get; set;}
        [Detail][Many(ViewNameofWarehouse.IncomingTag)] public List<IncomingTag> IncomingTags {get; set;}
    }
    public class EmployerWCommodity : EmployerCommodity
    {
        [Get]public string Type {get; set;}
        [Get]public string PakcingBarcode {get; set;}
        [Detail]public double? Width { get; set; }
        [Detail]public double? height { get; set; }
        [Detail]public double? length { get; set; }
        [Get]public int Quantity {get; set;}
        [Get]public string MCommodityId {get; set;}
        [Get]public string TCommodityId {get; set;}    
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public List<SWCommodity> SWCommodities {get; set;}  // 입고
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public List<EWCommodity> EWCommodities {get; set;}  // 출고
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public List<MWCommodity> MWCommodities {get; set;}  // 적재
        [Detail][One(ViewNameofWarehouse.Warehouse)] public Warehouse Warehouse { get; set; }
    }
    public class EmployerSWCommodity : EmployerSStatus
    {
        [Get]public int IncomingQuantity { get; set; }
        [Get]public string IncomingTagId {get; set;}
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public List<MWCommodity> MWCommodities {get; set;}
        [Detail][One(ViewNameofWarehouse.WCommodity)] public WCommodity WCommodity {get; set;}
        [Detail][One(ViewNameofWarehouse.Warehouse)] public Warehouse Warehouse {get; set;}
    }
    public class EmployerMWCommodity : EmployerMStatus
    {
        [Detail][Many(ViewNameofWarehouse.EWCommodity)]public List<EWCommodity> EWCommodities {get; set;}
        [Detail][One(ViewNameofWarehouse.LoadFrame)]public LoadFrame LoadFrame {get; set;}
        [Detail][One(ViewNameofWarehouse.Warehouse)] public Warehouse Warehouse {get; set;}
        [Detail][One(ViewNameofWarehouse.SWCommodity)]public SWCommodity SWCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity)] public WCommodity WCommodity { get; set; }
    }
    public class EmployerEWCommodity : EmployerEStatus
    {
        [Get]public int OutgoingQuantity {get; set;}
        [Get][One(ViewNameofWarehouse.WCommodity)] public WCommodity WCommodity {get; set;}
        [Get][One(ViewNameofWarehouse.Warehouse)] public Warehouse Warehouse {get; set;}
        [Get][One(ViewNameofWarehouse.MWCommodity)] public MWCommodity  MWCommodity { get; set; }
    }
    public class EmployerLoadFrame : EmployerEntity
    {
        public List<MWCommodity> MWCommodities { get; set; }
        public Warehouse Warehouse { get; set; }
    }
    public class EmployerDotBarcode : EmployerEntity
    {

    }
    public class EmployerWorkingDesk : EmployerEntity
    {
        public bool IsUsed {get; set;}
        public Warehouse Warehouse {get; set;}
    }
    public class EmployerDividedTag : EmployerEntity
    {
        [Get]public bool Attached { get; set; }
        [Get]public string IncomingTagId {get; set;}
        [Get]public string WarehouseId {get; set;}
        [Get][One(ViewNameofWarehouse.IncomingTag)] public IncomingTag IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public Warehouse Warehouse { get; set; }
    }
    public class EmployerIncomingTag : EmployerEntity
    {
        [Get] public string SWCommodityId { get; set; }
        [Get] public string WareohuseId {get; set;}
        [Get][One(ViewNameofWarehouse.Warehouse)]public Warehouse Warehouse { get; set; }
        [Get][Many(ViewNameofWarehouse.DividedTag)]public List<DividedTag> DividedTags { get; set; }
    }
}
