using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofCommon;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofWarehouse
{
    public static class ViewNameofWarehouse
    {
        public const string Warehouse = "물류센터";
        public const string WCommodity = "창고상품";
        public const string SWCommodity = "입고상품";
        public const string MWCommodity = "적재상품";
        public const string EWCommodity = "출고상품";
        public const string LoadFrame = "적재대";
        public const string WorkingDesk = "워킹데스크";
        public const string IncomingTag = "입고태그";
        public const string DividedTag = "분할태그";
        public const string DotBarcode ="도트태그";
        public const string LoadFrameTag = "적재태그";
    }
    public class WarehouseDTO : CenterDTO
    {
        [Detail][Many(ViewNameofWarehouse.WCommodity, typeof(List<WCommodity>))] public string? WCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity, typeof(List<SWCommodity>))] public string? SWCommodities { get; set; }
        [Detail][Many(ViewNameofWarehouse.LoadFrame, typeof(List<LoadFrame>))] public string? LoadFrames { get; set; }
        [Detail][Many(ViewNameofWarehouse.DotBarcode, typeof(List<DotBarcode>))] public string? DotBarcodes { get; set; }
        [Detail][Many(ViewNameofWarehouse.WorkingDesk, typeof(List<WorkingDesk>))] public string? WorkingDesks { get; set; }
        [Detail][Many(ViewNameofWarehouse.DividedTag, typeof(List<DividedTag>))] public string? DividedTags { get; set; }
        [Detail][Many(ViewNameofWarehouse.IncomingTag, typeof(List<IncomingTag>))] public string? IncomingTags { get; set; }
    }
    public class WCommodityDTO : CommodityDTO
    {
        [Query(QueryCode)][Get] public string? Type { get; set; }
        [Query][Get] public string? PakcingBarcode { get; set; }
        [Query][Detail] public double? Width { get; set; }
        [Query][Detail] public double? height { get; set; }
        [Query][Detail] public double? length { get; set; }
        [Query][Get] public int Quantity { get; set; }
        [Query][Get] public string? MCommodityId { get; set; }
        [Query][Get] public string? TCommodityId { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity, typeof(List<SWCommodity>))] public string? SWCommodities { get; set; }  // 입고
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }  // 출고
        [Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }  // 적재
        [Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
    public class SWCommodityDTO : SStatusDTO
    {
        [Query][Get] public int IncomingQuantity { get; set; }
        [Query][Get] public string? IncomingTagId { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
    public class MWCommodityDTO : MStatusDTO
    {
        [Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.LoadFrame, typeof(LoadFrame))] public string? LoadFrame { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Detail][One(ViewNameofWarehouse.SWCommodity, typeof(SWCommodity))] public string? SWCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
    }
    public class EWCommodityDTO : EStatusDTO
    {
        [Query][Get] public int OutgoingQuantity { get; set; }
        [Get][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Get][One(ViewNameofWarehouse.MWCommodity, typeof(MWCommodity))] public string? MWCommodity { get; set; }
    }
    public class DiviedTagDTO : EntityDTO
    {
        [Query][Get] public bool Attached { get; set; }
        [Query][Get] public string? IncomingTagId { get; set; }
        [Query][Get] public string? WarehouseId { get; set; }
        [Get][One(ViewNameofWarehouse.IncomingTag, typeof(IncomingTag))] public string? IncomingTag { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
    public class DotBarcodeDTO : EntityDTO
    {

    }
    public class IncomingTagDTO : EntityDTO
    {
        [Query][Get] public string? SWCommodityId { get; set; }
        [Query][Get] public string? WareohuseId { get; set; }
        [Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Get][Many(ViewNameofWarehouse.DividedTag, typeof(List<DividedTag>))] public string? DividedTags { get; set; }
    }
    public class LoadFrameDTO : EntityDTO
    {
        [Detail][Many(typeof(List<MWCommodity>))]public string? MWCommodities { get; set; }
        [Detail][Many(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
    public class WorkingDeskDTO : EntityDTO
    {
        [Query(QueryCode.Bool)]public bool IsUsed { get; set; }
        [Detail][One(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}