using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofProduct
{
    public class EPCommodityDTO : EStatusDTO
    {
        [Many][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Many][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Many][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Many][One(ViewNameofProductCenter.MPCommodity, typeof(MPCommodity))] public string? MPCommodity {get; set;}
    }
    public class MPCommodityDTO : MStatusDTO
    {
        [Detail][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Detail][One(ViewNameofProductCenter.SPCommodity, typeof(SPCommodity))] public string? SPCommodity {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity, typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
    }
    public class PCommodityDTO : CommodityDTO
    {
        [Detail]public string? Category {get; set;}
        [Detail] public string? Brand {get; set;}
        [Detail][Many(typeof(List<SPCommodity>))] public string? SPCommodities {get; set;}
        [Detail][Many(typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
        [Detail][Many(typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Detail][One(typeof(Producter))]public string? Producter {get; set;} 
    }
    public class ProductCenterDTO : CenterDTO
    {
        public string? Producters {get; set;}
        public string? CoprNumber {get; set;}
        [Detail][Many(ViewNameofProductCenter.ProductCenter, typeof(List<ProductLand>))] public string? ProductLands {get; set;}
        [Detail][Many(ViewNameofProductCenter.PCommodity, typeof(List<PCommodity>))] public string? PCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.SPCommodity, typeof(List<SPCommodity>))] public string? SPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity, typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity, typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
    }
    public class ProducterDTO : CenterDTO
    {
        [Detail][Many(typeof(List<ProductCenter>))]public string? ProductCenters { get; set; } 
        [Detail][Many(typeof(List<PCommodity>))]public string? PCommodities { get; set; }
        [Detail][Many(typeof(List<SPCommodity>))]public string? SPCommodities{ get; set; }
        [Detail][Many(typeof(List<MPCommodity>))]public string? MPCommodities { get; set; }    
        [Detail][Many(typeof(List<EPCommodity>))]public string? EPCommodities { get; set;}
    }
    public class ProductLandDTO : EntityDTO
    {
        [Get]public string? StartedTime {get; set;}
        [Get]public string? AnticipatingEndedTime {get; set;}
        [Get]public string? Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public string? OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Detail][One(typeof(ProductCenter))]public string? ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity, typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
    }
    public class SPCommodityDTO : SStatusDTO
    {
        [Get]public string? StartedTime {get; set;}
        [Get]public string? AnticipatingEndedTime {get; set;}
        [Get]public string? Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        [Get]public string? OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Detail][One(typeof(ProductCenter))]public string? ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity, typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
    }
    
}