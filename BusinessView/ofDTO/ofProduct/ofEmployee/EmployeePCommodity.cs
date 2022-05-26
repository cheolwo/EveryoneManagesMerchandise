using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofProduct;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(PCommodity))]
    public class EmployeePCommodity : EmployeeCommodity
    {
        [Query][Detail]public string? Category {get; set;}
        [Query][Detail] public string? Brand {get; set;}
        [Many(typeof(List<SPCommodity>))] public string? SPCommodities {get; set;}
        [Many(typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
        [Many(typeof(List<EPCommodity>))] public string? EPCommodities {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [One(typeof(Producter))]public string? Producter {get; set;}  
    }
}
