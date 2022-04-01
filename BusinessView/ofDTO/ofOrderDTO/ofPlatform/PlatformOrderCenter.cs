using BusinessData;
using BusinessData.ofOrder.ofModel;
using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofOrder.ofPlatform
{
    public class PlatformOrderCenter : PlatformCenter
    {
        [Detail][Many(ViewNameofOrderCenter.OCommodity)] public string OCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity)] public string SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public string MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)] public string EOCommodities { get; set; }
    }
    public class PlatformOCommodity : PlatformCommodity
    {
        [Get] public string OrderId { get; set; } // 이거의 존재는 Order Table 이라는 테이블의 존재를 의미하는데..
        public string OrderType { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity)] public string SOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public string MOCommodities { get; set; }
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)] public string EOCommodities { get; set; }
        [Detail] public string OrderCenter { get; set; }
    }
    public class PlatformSOCommodity : PlatformSStatus
    {
        public string Price { get; set; }
        public string QualityTerms { get; set; }
        public string Incorterms { get; set; }
        [Detail] public string OCommodity { get; set; }
        [Detail] public string OrderCenter { get; set; }
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)] public string MOCommodities { get; set; }
    }
    public class PlatformMOCommodity : PlatformMStatus
    {
        [Detail] public string OCommodity { get; set; }
        [Detail] public string OrderCenter { get; set; }
        [Detail] public string SOCommodity { get; set; }
        public string EOCommodities { get; set; }
    }
    public class PlatformEOCommodity : PlatformEStatus
    {
        [Get] public int OutgoingQuantity { get; set; } // 출고수량
        public string MOCommodity { get; set; }
        public string OCommodity { get; set; }
        public string OrderCenter { get; set; }
    }
}
