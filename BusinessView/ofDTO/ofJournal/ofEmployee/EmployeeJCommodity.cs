using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofJournal;
namespace BusinessView.ofDTO.ofJournal.ofEmployee
{
    public class EmployeeJCommodity : EmployeeCommodity
    {
        public string? OCommodityNo { get; set; }
        public string? Journals { get; set; }
        public string? JournalCenter { get; set; }
    }
}
