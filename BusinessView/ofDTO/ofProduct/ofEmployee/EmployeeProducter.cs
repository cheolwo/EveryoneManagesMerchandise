using AutoMapper;
using BusinessData.ofProduct;
using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(Producter))]
    public class EmployeeProducter : EmployeeCenter
    {
        [Many(typeof(List<ProductCenter>))][Detail]public string? ProductCenters { get; set; } 
        [Many(typeof(List<PCommodity>))][Detail]public string? PCommodities { get; set; }
        [Many(typeof(List<SPCommodity>))][Detail]public string? SPCommodities{ get; set; }
        [Many(typeof(List<MPCommodity>))][Detail]public string? MPCommodities { get; set; }    
        [Many(typeof(List<EPCommodity>))][Detail]public string? EPCommodities { get; set;}
    }
}
