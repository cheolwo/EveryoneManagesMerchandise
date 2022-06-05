using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(JournalCenter))]
    [HttpDTOService(typeof(EmployeeJournalCenterService))]
    public class EmployeeJournalCenter : JournalCenterDTO
    {
        
    }
}
