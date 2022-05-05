﻿using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofOrder.ofEmployee
{
    public class EmployeeOrderCenter : EmployeeCenter
    {
        [Detail][Many(ViewNameofOrderCenter.OCommodity)] public string? OCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity)] public string? SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public string? MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)] public string? EOCommodities { get; set; }
    }
}
