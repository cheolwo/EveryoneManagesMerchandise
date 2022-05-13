using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofEmployee;
using BusinessView.ofMarket;

namespace BusinessView.ofMarket.ofEmployee
{
    public class EmployeeMarket : EmployeeCenter
    {
        [Get]public string NameofMarket { get; set; }
        [Many(ViewNameofMarket.PlatMarket)]public string PlatMarkets { get; set; }
        [Many(ViewNameofMarket.MCommodity)]public string MCommodities {get; set;}
        [Many(ViewNameofMarket.SMCommodity)]public string SMCommodities {get; set; }
        [Many(ViewNameofMarket.MMCommodity)]public string MMCommodities {get; set;}
        [Many(ViewNameofMarket.EMCommodity)]public string EMCommodities {get; set;}
    }
}
