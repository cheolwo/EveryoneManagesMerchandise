using BusinessData.ofProduct;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofProduct.ofEmployer
{
    public class EmployerProducter : EmployerCenter
    {
        public string? ProductCenter { get; set; } 
        public string? PCommodity { get; set; }
        public string? SPCommodity { get; set; }
        public string? MPCommodities { get; set; }    
        public string? EPCommodity { get; set;}
    }
}
