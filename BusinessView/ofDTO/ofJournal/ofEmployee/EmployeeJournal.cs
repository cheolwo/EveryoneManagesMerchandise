using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofJournal.ofEmployee
{
    public class EmployeeJournal : EmployeeEntity
    {
        public string? Debits { get; set; }         // Json 으로 처리한다.
        public string? Credits {get; set; }       // Json 으로 처리한다.
        public string? AwesomeInfo {get; set;}
        public string? JCommodity {get; set;}
    }
}
