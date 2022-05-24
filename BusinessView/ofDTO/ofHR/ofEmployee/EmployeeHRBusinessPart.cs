using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofHR;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;

namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HRBusinessPart))]
    public class EmployeeHRBusinessPart : EmployeeEntity
    {
        [Get]public string? PartName {get; set;}
        [Get]public string? PossibleAPIInfos {get; set;}
        [Get][One(typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}