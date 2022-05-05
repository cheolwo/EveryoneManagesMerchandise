using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofMarket.ofEmployer
{
    public class EmployerSMCommodity : EmployerSStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public string? MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.MMCommodity)]public string? MMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public string? Market {get; set;}
        public string? SWCommodityId {get; set;}
    }
}
