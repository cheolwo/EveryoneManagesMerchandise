﻿using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofOrder.ofEmployer
{
    public class EmployerOCommodity : EmployerCommodity
    {
        [Get] public string OrderId { get; set; } // 이거의 존재는 Order Table 이라는 테이블의 존재를 의미하는데..
        public string OrderType { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity)] public string SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public string MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)] public string EOCommodities { get; set; }
        [Detail] public string OrderCenter { get; set; }
    }
}