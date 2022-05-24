using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData.ofHR;
using BusinessData.ofHumanResource.ofRepository;

namespace BusinessView.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRCenter))]
    public class EmployerHRCenter : EmployerCenter
    {
        public string? JournalCenterId {get; set;}
        [Get]public string? BusinessNumber { get; set; }
        [Detail][Many(typeof(List<HREmployee>))]public string? HREmployees {get; set;}
        [Detail][Many(typeof(List<EmployeeRole>))]public string? EmployeeRoles {get; set;}
        [Detail][Many(typeof(List<HRRole>))]public string? HRRoles {get; set;}
    }
}