using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
using BusinessData.ofHumanResource.ofRepository;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRCenter))]
    public class EmployerHRCenter : EmployerCenter
    {
        [Query][Get]public string? JournalCenterId {get; set;}
        [Query][Get]public string? BusinessNumber { get; set; }
        [Detail][Many(typeof(List<HREmployee>))]public string? HREmployees {get; set;}
        [Detail][Many(typeof(List<EmployeeRole>))]public string? EmployeeRoles {get; set;}
        [Detail][Many(typeof(List<HRRole>))]public string? HRRoles {get; set;}
    }
}