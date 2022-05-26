﻿using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofMarket;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofMarket.ofPlatform
{
    [AutoMap(typeof(PlatMarket))]
    public class PlatformPlatMarket : PlatformCenter
    {
        [Query][Get]public string? NameofPlatForm {get; set;}
        [Query][Get]public string? VendorId { get; set; }
        [Get]public string? VendorPassword {get; set;}
        [Detail]public byte[]? AccessKey { get; set; }
        [Detail]public byte[]? SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity, typeof(List<PMMCommodity>))] public string? PMMCommodities {get; set;}
    }
}
