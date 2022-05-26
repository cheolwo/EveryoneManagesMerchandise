using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRBusinessPart))]
    public class EmployerHRBusinessPart : EmployerEntity
    {
        [Query][Get]public string? PartName {get; set;}
        [Query][Get]public string? PossibleAPIInfos {get; set;}
        [Get][One(typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}