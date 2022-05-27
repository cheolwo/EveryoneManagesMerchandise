using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;

namespace BusinessView.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(Journal))]
    public class EmployeeJournal : JournalDTO
    {
        
    }
}
