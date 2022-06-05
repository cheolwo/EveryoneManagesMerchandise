using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRCenter))]
    [HttpDTOService(typeof(EmployerHRCenterService))]
    public class EmployerHRCenter : HRCenterDTO
    {
        
    }
}