using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer
{
    [AutoMap(typeof(Journal))]
    [HttpDTOService(typeof(EmployerJournalService))]
    public class EmployerJournal : JournalDTO
    {
        
    }
}
