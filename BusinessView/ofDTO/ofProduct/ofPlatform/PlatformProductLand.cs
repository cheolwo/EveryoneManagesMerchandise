﻿using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofProduct;
namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    [AutoMap(typeof(ProductLand))]
    public class PlatformProductLand : PlatformEntity
    {
        [Get]public string? StartedTime {get; set;}
        [Get]public string? AnticipatingEndedTime {get; set;}
        [Get]public string? Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public string? OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity, typeof(PCommodity))] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand, typeof(ProductLand))] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter, typeof(Producter))] public string? Producter { get; set;}
        [Detail][One(typeof(ProductCenter))]public string? ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity, typeof(List<MPCommodity>))] public string? MPCommodities {get; set;}
    }
}
