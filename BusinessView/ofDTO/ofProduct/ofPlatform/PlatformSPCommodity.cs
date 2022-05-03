﻿using BusinessData;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofProduct.ofPlatform
{
    public class PlatformSPCommodity : PlatformSStatus
    {
        [Get]public string StartedTime {get; set;}
        [Get]public string AnticipatingEndedTime {get; set;}
        [Get]public string Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public List<string> OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity)] public string PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public string Producter { get; set;}
        public string ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public string MPCommodities {get; set;}
    }   
}