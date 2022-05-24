using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;

namespace BusinessView.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(Journal))]
    public class EmployeeJournal : EmployeeEntity
    {
        public string? Debits { get; set; }         // Json 으로 처리한다.
        public string? Credits {get; set; }       // Json 으로 처리한다.
        public string? AwesomeInfo {get; set;}
        public string? JCommodity {get; set;}
    }
}
