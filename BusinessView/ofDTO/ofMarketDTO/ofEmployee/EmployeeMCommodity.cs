﻿using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofMarket.ofEmployee
{
    public class EmployeeMCommodity : EmployeeCommodity
    {
        [One(ViewNameofMarket.Market)]public string Market {get; set;}
        [One(ViewNameofMarket.DetailofMCommodity)]public string DetailofMCommodity { get; set; }  // Json 으로 처리한다.
        [One(ViewNameofMarket.Option)]public List<Option> Options { get; set; }
        [One(ViewNameofMarket.SMCommodity)]public string SMCommodities {get; set;}
        [One(ViewNameofMarket.MMCommodity)]public string MMCommodities {get; set;}
        [One(ViewNameofMarket.EMCommodity)]public string EMCommodities {get; set;}
    }
}
