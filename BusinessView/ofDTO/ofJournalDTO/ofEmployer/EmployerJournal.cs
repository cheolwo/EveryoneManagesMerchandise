using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofJournalDTO.ofEmployer
{
    public class EmployerJournal : EmployerEntity
    {
        public string Debits { get; set; }         // Json 으로 처리한다.
        public string Credits {get; set; }       // Json 으로 처리한다.
        public string AwesomeInfo {get; set;}
        public string JCommodity {get; set;}
    }
}
