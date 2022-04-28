using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofMarket.ofEmployer
{
    public class EmployerEMCommodity : EmployerEStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public string MCommodity {get; set;}
        [Detail][One(ViewNameofMarket.MMCommodity)]public string MMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.PlatMarket)]public string PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public string Market {get; set;}
    }
}
