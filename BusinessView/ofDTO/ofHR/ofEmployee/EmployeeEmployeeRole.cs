using AutoMapper;
using BusinessData;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofHR;
namespace BusinessView.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(EmployeeRole))]
    public class EmployeeEmployeeRole : EmployeeEntity
    {
        [Detail][One(typeof(HRRole))]public string? HRRole {get; set;}
        [Detail][One(typeof(HRBusinessPart))]public string? HRBusinessPart {get; set;}
        [Detail][One(typeof(HREmployee))]public string? HREmployee {get; set;}
        [Detail]public string? PossibleAPIInfos {get; set;}
        [One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string? HRCenter {get; set;}
    }
}