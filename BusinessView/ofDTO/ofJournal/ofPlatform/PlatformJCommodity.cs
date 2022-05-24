using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;

namespace BusinessView.ofDTO.ofJournal.ofPlatform
{
    [AutoMap(typeof(JCommodity))]
    public class PlatformJCommodity : PlatformCommodity
    {
        public string? OCommodityNo { get; set; }
        public string? Journals { get; set; }
        public string? JournalCenter { get; set; }
    }
}
