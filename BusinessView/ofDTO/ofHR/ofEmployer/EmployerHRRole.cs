using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRRole))]
    public class EmployerHRRole : EmployerEntity
    {
        [Query][Get]public string? DetailName {get; set;}
        [One(ViewNameofHRCenter.HRCenter,typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}