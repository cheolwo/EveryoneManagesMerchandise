﻿using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData;
using BusinessData.ofTrade.ofModel;
namespace BusinessView.ofTrade.ofEmployer
{
    [AutoMap(typeof(ETCommodity))]
    public class EmployerETCommodity : EmployerEStatus
    {
        [Get]public string? MTCommodityId {get; set;}
        [Get]public string? SWCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity { get; set; }
    }
}
