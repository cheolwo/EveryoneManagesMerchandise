using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer
{
    [AutoMap(typeof(JCommodity))]
    [HttpDTOService(typeof(EmployerJCommodityService))]
    public class EmployerJCommodity : JCommodityDTO
    {
       
    }
}
