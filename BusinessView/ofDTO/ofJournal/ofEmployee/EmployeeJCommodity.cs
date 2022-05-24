using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;
namespace BusinessView.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(JCommodity))]
    public class EmployeeJCommodity : EmployeeCommodity
    {
        public string? OCommodityNo { get; set; }
        public string? Journals { get; set; }
        public string? JournalCenter { get; set; }
    }
}
