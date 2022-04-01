﻿using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofCommon.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofOrder.ofPlatform
{
    public class PlatformOrderCenter : PlatformCenter
    {
        [Detail][Many(ViewNameofOrderCenter.OCommodity)] public List<OCommodity> OCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity)] public List<SOCommodity> SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public List<MOCommodity> MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)] public List<EOCommodity> EOCommodities { get; set; }
    }
    public class PlatformOCommodity : PlatformCommodity
    {
        [Get] public string OrderId { get; set; } // 이거의 존재는 Order Table 이라는 테이블의 존재를 의미하는데..
        public string OrderType { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity)] public List<SOCommodity> SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public List<MOCommodity> MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)] public List<EOCommodity> EOCommodities { get; set; }
        [Detail] public OrderCenter OrderCenter { get; set; }
    }
    public class PlatformSOCommodity : PlatformSStatus
    {
        public string Price { get; set; }
        public string QualityTerms { get; set; }
        public string Incorterms { get; set; }
        [Detail] public OCommodity OCommodity { get; set; }
        [Detail] public OrderCenter OrderCenter { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public List<MOCommodity> MOCommodities { get; set; }
    }
    public class PlatformMOCommodity : PlatformMStatus
    {
        [Detail] public OCommodity OCommodity { get; set; }
        [Detail] public OrderCenter OrderCenter { get; set; }
        [Detail] public SOCommodity SOCommodity { get; set; }
        public List<EOCommodity> EOCommodities { get; set; }
    }
    public class PlatformEOCommodity : PlatformEStatus
    {
        [Get] public int OutgoingQuantity { get; set; } // 출고수량
        public MOCommodity MOCommodity { get; set; }
        public OCommodity OCommodity { get; set; }
        public OrderCenter OrderCenter { get; set; }
    }
}