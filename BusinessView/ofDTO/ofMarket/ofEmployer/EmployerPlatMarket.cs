using AutoMapper;
using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using NMemory.Data;
using BusinessData.ofMarket;
namespace BusinessView.ofDTO.ofMarket.ofEmployer
{
    [AutoMap(typeof(PlatMarket))]
    public class EmployerPlatMarket : EmployerCenter
    {
        [Query][Get]public string? NameofPlatForm {get; set;}
        [Query][Get]public string? VendorId { get; set; }
        [Get]public string? VendorPassword {get; set;}
        [Detail]public Binary? AccessKey { get; set; }
        [Detail]public Binary? SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity, typeof(List<PMMCommodity>))] public string? PMMCommodities {get; set;}
    }
}
