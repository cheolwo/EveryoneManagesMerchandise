using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofCommon;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofExternal.ofCommon;

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
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.WCommodity, typeof(List<WCommodity>))] public string? WCommodities { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.SWCommodity, typeof(List<SWCommodity>))] public string? SWCommodities { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.LoadFrame, typeof(List<LoadFrame>))] public string? LoadFrames { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.DotBarcode, typeof(List<DotBarcode>))] public string? DotBarcodes { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.WorkingDesk, typeof(List<WorkingDesk>))] public string? WorkingDesks { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.DividedTag, typeof(List<DividedTag>))] public string? DividedTags { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.IncomingTag, typeof(List<IncomingTag>))] public string? IncomingTags { get; set; }
    }
    public class WCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.String)][Get] public string? Type { get; set; }
        [Query(QueryCode.String)][Get] public string? PakcingBarcode { get; set; }
        [Query(QueryCode.Int)][Detail] public double? Width { get; set; }
        [Query(QueryCode.Int)][Detail] public double? height { get; set; }
        [Query(QueryCode.Int)][Detail] public double? length { get; set; }
        [Query(QueryCode.Int)][Get] public int Quantity { get; set; }
        [Query(QueryCode.ForeignKey)][Get] public string? MCommodityId { get; set; }
        [Query(QueryCode.ForeignKey)][Get] public string? TCommodityId { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.SWCommodity, typeof(List<SWCommodity>))] public string? SWCommodities { get; set; }  // 입고
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }  // 출고
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }  // 적재
        [Query(QueryCode.With)][Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
    public class SWCommodityDTO : SStatusDTO
    {
        [Query(QueryCode.Int)][Get] public int IncomingQuantity { get; set; }
        [Query(QueryCode.ForeignKey)][Get] public string? IncomingTagId { get; set; }
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
    public class MWCommodityDTO : MStatusDTO
    {
        [Query(QueryCode.With)][Detail][Many(ViewNameofWarehouse.EWCommodity, typeof(List<EWCommodity>))] public string? EWCommodities { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofWarehouse.LoadFrame, typeof(LoadFrame))] public string? LoadFrame { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofWarehouse.SWCommodity, typeof(SWCommodity))] public string? SWCommodity { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
    }
    public class EWCommodityDTO : EStatusDTO
    {
        [Query(QueryCode.Int)][Get] public int OutgoingQuantity { get; set; }
        [Query(QueryCode.With)][Get][One(ViewNameofWarehouse.WCommodity, typeof(WCommodity))] public string? WCommodity { get; set; }
        [Query(QueryCode.With)][Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Query(QueryCode.With)][Get][One(ViewNameofWarehouse.MWCommodity, typeof(MWCommodity))] public string? MWCommodity { get; set; }
    }
    public class DiviedTagDTO : EntityDTO
    {
        [Query(QueryCode.Bool)][Get] public bool Attached { get; set; }
        [Query(QueryCode.ForeignKey)][Get] public string? IncomingTagId { get; set; }
        [Query(QueryCode.ForeignKey)][Get] public string? WarehouseId { get; set; }
        [Query(QueryCode.With)][Get][One(ViewNameofWarehouse.IncomingTag, typeof(IncomingTag))] public string? IncomingTag { get; set; }
        [Query(QueryCode.With)][Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
    public class DotBarcodeDTO : EntityDTO
    {

    }
    public class IncomingTagDTO : EntityDTO
    {
        [Query(QueryCode.ForeignKey)][Get] public string? SWCommodityId { get; set; }
        [Query(QueryCode.ForeignKey)][Get] public string? WareohuseId { get; set; }
        [Query(QueryCode.With)][Get][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
        [Query(QueryCode.With)][Get][Many(ViewNameofWarehouse.DividedTag, typeof(List<DividedTag>))] public string? DividedTags { get; set; }
    }
    public class LoadFrameDTO : EntityDTO
    {
        [Query(QueryCode.With)][Detail][Many(typeof(List<MWCommodity>))]public string? MWCommodities { get; set; }
        [Query(QueryCode.With)][Detail][Many(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
    public class WorkingDeskDTO : EntityDTO
    {
        [Query(QueryCode.Bool)]public bool IsUsed { get; set; }
        [Query(QueryCode.With)][Detail][One(typeof(Warehouse))]public string? Warehouse { get; set; }
    }
}