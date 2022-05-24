using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofMarket;
using NMemory.Data;

namespace BusinessView.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(PlatMarket))]
    public class EmployeePlatMarket : EmployeeCenter
    {
        [Get]public string? NameofPlatForm {get; set;}
        [Get]public string? VendorId { get; set; }
        [Get]public string? VendorPassword {get; set;}
        [Detail]public Binary? AccessKey { get; set; }
        [Detail]public Binary? SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity, typeof(List<PMMCommodity>))] public string? PMMCommodities {get; set;}
    }
}
