using BusinessData.ofProduct;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofProduct.ofEmployer
{
    public class EmployerProducter : EmployerCenter
    {
        public ProductCenter ProductCenter { get; set; } 
        public string PCommodity { get; set; }
        public string SPCommodity { get; set; }
        public string MPCommodities { get; set; }    
        public string EPCommodity { get; set;}
    }
}
