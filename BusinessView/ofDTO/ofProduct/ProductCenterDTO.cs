using BusinessData;
using BusinessData.ofProduct;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofExternal.ofCommon;
using System;
namespace BusinessView.ofDTO.ofProduct
{
    public class EPCommodityDTO : EStatusDTO
    {
        [Query(QueryCode.With)][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Query(QueryCode.With)][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Query(QueryCode.With)][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Query(QueryCode.With)][One(ViewNameofProductCenter.MPCommodity, typeof(MPCommodity))] public string? MPCommodity {get; set;}
    }
    public class MPCommodityDTO : MStatusDTO
    {
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.SPCommodity, typeof(SPCommodity))] public string? SPCommodity {get; set;}
        [Query(QueryCode.With)][Detail][Many(ViewNameofProductCenter.EPCommodity, typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
    }
    public class PCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.String)][Detail]public string? Category {get; set;}
        [Query(QueryCode.String)][Detail] public string? Brand {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<SPCommodity>))] public string? SPCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Query(QueryCode.With)][Detail][One(typeof(Producter))]public string? Producter {get; set;} 
    }
    public class ProductCenterDTO : CenterDTO
    {
        public string? Producters {get; set;}
        [Query(QueryCode.String)]public string? CoprNumber {get; set;}
        [Query(QueryCode.With)][Detail][Many(ViewNameofProductCenter.ProductCenter, typeof(List<ProductLand>))] public string? ProductLands {get; set;}
        [Query(QueryCode.With)][Detail][Many(ViewNameofProductCenter.PCommodity, typeof(List<PCommodity>))] public string? PCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(ViewNameofProductCenter.SPCommodity, typeof(List<SPCommodity>))] public string? SPCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(ViewNameofProductCenter.MPCommodity, typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
        [Query(QueryCode.With)][Detail][Many(ViewNameofProductCenter.EPCommodity, typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
    }
    public class ProducterDTO : CenterDTO
    {
        [Query(QueryCode.With)][Detail][Many(typeof(List<ProductCenter>))]public string? ProductCenters { get; set; } 
        [Query(QueryCode.With)][Detail][Many(typeof(List<PCommodity>))]public string? PCommodities { get; set; }
        [Query(QueryCode.With)][Detail][Many(typeof(List<SPCommodity>))]public string? SPCommodities{ get; set; }
        [Query(QueryCode.With)][Detail][Many(typeof(List<MPCommodity>))]public string? MPCommodities { get; set; }    
        [Query(QueryCode.With)][Detail][Many(typeof(List<EPCommodity>))]public string? EPCommodities { get; set;}
    }
    public class ProductLandDTO : EntityDTO
    {
        [Query(QueryCode.Time)][Get]public DateTime? StartedTime {get; set;}
        [Query(QueryCode.String)][Get]public string? AnticipatingEndedTime {get; set;}
        [Query(QueryCode.String)][Get]public string? Unit {get; set;}
        [Query(QueryCode.Int)][Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public string? OrderGroups {get; set;}
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Query(QueryCode.With)][Detail][One(typeof(ProductCenter))]public string? ProductCenter {get; set;}
        [Query(QueryCode.With)][Detail][Many(ViewNameofProductCenter.MPCommodity, typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
    }
    public class SPCommodityDTO : SStatusDTO
    {
        [Query(QueryCode.Time)][Get]public DateTime? StartedTime {get; set;}
        [Query(QueryCode.Time)][Get]public DateTime? AnticipatingEndedTime {get; set;}
        [Query(QueryCode.String)][Get]public string? Unit {get; set;}
        [Query(QueryCode.Int)][Get]public float AnticipatingQuantity {get; set;}
        [Get]public string? OrderGroups {get; set;}
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Query(QueryCode.With)][Detail][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Query(QueryCode.With)][Detail][One(typeof(ProductCenter))]public string? ProductCenter {get; set;}
        [Query(QueryCode.With)][Detail][Many(ViewNameofProductCenter.MPCommodity, typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
    }
    
}