using BusinessData.ofProduct;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofProduct.ofEmployee
{
    public class EmployeeProducter : EmployeeCenter
    {
        public string? ProductCenter { get; set; } 
        public string? PCommodity { get; set; }
        public string? SPCommodity { get; set; }
        public string? MPCommodities { get; set; }    
        public string? EPCommodity { get; set;}
    }
}
