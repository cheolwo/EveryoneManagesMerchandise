using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofMarket.ofEmployer
{
    public class EmployerMMCommodity : EmployerMStatus
    {
        [Detail][One(ViewNameofMarket.PlatMarket)]public string PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public string Market {get; set;}
        [Detail][One(ViewNameofMarket.MCommodity)]public string MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.EMCommodity)]public string EMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.PMMCommodity)]public string PMMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.SMCommodity)]public string SMCommodity {get; set;}
    }
}
