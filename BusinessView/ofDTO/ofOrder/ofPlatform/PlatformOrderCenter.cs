﻿using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofOrder;
namespace BusinessView.ofDTO.ofOrder.ofPlatform
{
    public class PlatformOrderCenter : PlatformCenter
    {
        [Detail][Many(ViewNameofOrderCenter.OCommodity, typeof(List<OCommodity>)] public string? OCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity, typeof(List<SOCommodity>)] public string? SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public string? MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)] public string? EOCommodities { get; set; }
    }
}
