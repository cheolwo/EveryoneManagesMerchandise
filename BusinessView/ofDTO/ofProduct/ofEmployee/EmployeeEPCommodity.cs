using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessData.ofProduct;
namespace BusinessView.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(EPCommodity))]
    public class EmployeeEPCommodity : EmployeeEStatus
    {   
        [Many][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Many][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Many][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Many][One(ViewNameofProductCenter.MPCommodity, typeof(MPCommodity))] public string? MPCommodity {get; set;}
    }
}
