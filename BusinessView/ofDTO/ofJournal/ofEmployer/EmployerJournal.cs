using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;
namespace BusinessView.ofDTO.ofJournal.ofEmployer
{
    [AutoMap(typeof(Journal))]
    public class EmployerJournal : JournalDTO
    {
        
    }
}
