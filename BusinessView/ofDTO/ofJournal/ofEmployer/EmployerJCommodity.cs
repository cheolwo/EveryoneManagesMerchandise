using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;
namespace BusinessView.ofDTO.ofJournal.ofEmployer
{
    [AutoMap(typeof(JCommodity))]
    public class EmployerJCommodity : EmployerCommodity
    {
        public string? OCommodityNo { get; set; }
        public string? Journals { get; set; }
        public string? JournalCenter { get; set; }
    }
}
