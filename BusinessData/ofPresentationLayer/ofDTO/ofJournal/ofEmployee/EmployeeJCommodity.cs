using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(JCommodity))]
    [HttpDTOService(typeof(EmployeeJCommodityService))]
    public class EmployeeJCommodity : JCommodityDTO
    {
       
    }
}
