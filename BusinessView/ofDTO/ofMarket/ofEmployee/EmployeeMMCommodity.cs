﻿using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofMarket.ofEmployee
{
    public class EmployeeMMCommodity : EmployeeMStatus
    {
        [Detail][One(ViewNameofMarket.PlatMarket)]public string? PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public string? Market {get; set;}
        [Detail][One(ViewNameofMarket.MCommodity)]public string? MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.EMCommodity)]public string? EMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.PMMCommodity)]public string? PMMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.SMCommodity)]public string? SMCommodity {get; set;}
    }
}
