using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(Journal))]
    [HttpDTOService(typeof(EmployeeJournalService))]
    public class EmployeeJournal : JournalDTO
    {
        
    }
}
