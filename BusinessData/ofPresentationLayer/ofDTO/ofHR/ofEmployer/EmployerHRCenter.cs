using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRCenter))]
    public class EmployerHRCenter : HRCenterDTO
    {
        
    }
}