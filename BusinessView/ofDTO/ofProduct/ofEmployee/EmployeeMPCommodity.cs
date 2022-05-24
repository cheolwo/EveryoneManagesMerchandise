using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofProduct;
namespace BusinessView.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(MPCommodity))]
    public class EmployeeMPCommodity : EmployeeMStatus
    {   
        [Detail][One(ViewNameofProductCenter.PCommodity)] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public string? Producter { get; set;}
        [Detail][One(ViewNameofProductCenter.SPCommodity)] public string? SPCommodity {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity)] public string? EPCommodities {get; set;}
    }
}
