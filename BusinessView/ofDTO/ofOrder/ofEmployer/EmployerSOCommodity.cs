using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofOrder.ofEmployer
{
    public class EmployerSOCommodity : EmployerSStatus
    {
        public string Price { get; set; }
        public string QualityTerms { get; set; }
        public string Incorterms { get; set; }
        [Detail] public string OCommodity { get; set; }
        [Detail] public string OrderCenter { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public string MOCommodities { get; set; }
    }
}
