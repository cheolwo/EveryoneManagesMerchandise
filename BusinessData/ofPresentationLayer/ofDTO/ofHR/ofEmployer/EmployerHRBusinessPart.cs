using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRBusinessPart))]
    [HttpDTOService(typeof(EmployerHRBusinessPartService))]
    public class EmployerHRBusinessPart : HRBusinessPartDTO
    {
        
    }
}