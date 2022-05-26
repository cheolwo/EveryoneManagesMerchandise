﻿using AutoMapper;
using BusinessData;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessView.ofWarehouse;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(SWCommodity))]
    public class PlatformSWCommodity : PlatformSStatus
    {
        [Query][Get] public int IncomingQuantity { get; set; }
        [Query][Get] public string? IncomingTagId { get; set; }
        [Detail][Many(ViewNameofWarehouse.MWCommodity, typeof(List<MWCommodity>))] public string? MWCommodities { get; set; }
        [Detail][One(ViewNameofWarehouse.WCommodity, typeof(List<WCommodity>))] public string? WCommodity { get; set; }
        [Detail][One(ViewNameofWarehouse.Warehouse, typeof(Warehouse))] public string? Warehouse { get; set; }
    }
}
