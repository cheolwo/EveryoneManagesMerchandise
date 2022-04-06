using BusinessData;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofWarehouse.ofEmployer
{
    // Generic 의 경우 DTO 에서 Json String
    /*
    Serializing to a UTF-8 byte array is about 5-10% faster than using the string-based methods. 
    The difference is because the bytes (as UTF-8) don't need to be converted to strings (UTF-16).
    To serialize to a UTF-8 byte array, call the JsonSerializer.SerializeToUtf8Bytes method:

    C#
    byte[] jsonUtf8Bytes =JsonSerializer.SerializeToUtf8Bytes(weatherForecast);
     */
    public class EmployerWarehouse : EmployerCenter
    {
        [Detail][Many(ViewNameofWarehouse.WCommodity)] public string WCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public string EWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public string MWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public string SWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.LoadFrame)] public string LoadFrames { get; set; }
        [Detail][Many(ViewNameofWarehouse.DotBarcode)] public string DotBarcodes { get; set; }
        [Detail][Many(ViewNameofWarehouse.WorkingDesk)] public string WorkingDesks { get; set; }
        [Detail][Many(ViewNameofWarehouse.DividedTag)] public string DividedTags { get; set; }
        [Detail][Many(ViewNameofWarehouse.IncomingTag)] public string IncomingTags { get; set; }
    }
    public class EmployerWCommodity : EmployerCommodity
    {
        [Get] public string Type { get; set; }
        [Get] public string PakcingBarcode { get; set; }
        [Detail] public double? Width { get; set; }
        [Detail] public double? height { get; set; }
        [Detail] public double? length { get; set; }
        [Get] public int Quantity { get; set; }
        [Get] public string MCommodityId { get; set; }
        [Get] public string TCommodityId { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public string SWCommodities { get; set; }  // 입고
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public string EWCommodities { get; set; }  // 출고
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public string MWCommodities { get; set; }  // 적재
        [Detail][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
    }
    public class EmployerSWCommodity : EmployerSStatus
    {
        [Get] public int IncomingQuantity { get; set; }
        [Get] public string IncomingTagId { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public string MWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity)] public string WCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
    }
    public class EmployerMWCommodity : EmployerMStatus
    {
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public string EWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.LoadFrame)] public string LoadFrame { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Detail][One(ViewNameofWarehouse.SWCommodity)] public string SWCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity)] public string WCommodity { get; set; }
    }
    public class EmployerEWCommodity : EmployerEStatus
    {
        [Get] public int OutgoingQuantity { get; set; }
        [Get][One(ViewNameofWarehouse.WCommodity)] public string WCommodity { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Get][One(ViewNameofWarehouse.MWCommodity)] public string MWCommodity { get; set; }
    }
    public class EmployerLoadFrame : EmployerEntity
    {
        public string MWCommodities { get; set; }
        public string Warehouse { get; set; }
    }
    public class EmployerDotBarcode : EmployerEntity
    {

    }
    public class EmployerWorkingDesk : EmployerEntity
    {
        public bool IsUsed { get; set; }
        public string Warehouse { get; set; }
    }
    public class EmployerDividedTag : EmployerEntity
    {
        [Get] public bool Attached { get; set; }
        [Get] public string IncomingTagId { get; set; }
        [Get] public string WarehouseId { get; set; }
        [Get][One(ViewNameofWarehouse.IncomingTag)] public string IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
    }
    public class EmployerIncomingTag : EmployerEntity
    {
        [Get] public string SWCommodityId { get; set; }
        [Get] public string WareohuseId { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse)] public string Warehouse { get; set; }
        [Get][Many(ViewNameofWarehouse.DividedTag)] public string DividedTags { get; set; }
    }
}
