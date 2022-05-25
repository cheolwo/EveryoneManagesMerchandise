using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessData.ofProduct;
namespace BusinessView.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(MPCommodity))]
    public class EmployerMPCommodity : EmployerMStatus
    {   
        [Detail][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Detail][One(ViewNameofProductCenter.SPCommodity, typeof(SPCommodity))] public string? SPCommodity {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity, typeof(EPCommodity))] public string? EPCommodities {get; set;}
    }
}
