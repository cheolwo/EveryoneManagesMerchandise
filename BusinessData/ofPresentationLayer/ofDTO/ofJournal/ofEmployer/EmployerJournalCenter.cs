using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer
{
    [AutoMap(typeof(JournalCenter))]
    [HttpDTOService(typeof(EmployerJournalCenterService))]
    public class EmployerJournalCenter : JournalCenterDTO
    {
    }
}
