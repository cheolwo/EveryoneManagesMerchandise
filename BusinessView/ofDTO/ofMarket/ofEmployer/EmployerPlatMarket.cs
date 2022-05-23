using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using NMemory.Data;
using BusinessData.ofMarket;
namespace BusinessView.ofDTO.ofMarket.ofEmployer
{
    public class EmployerPlatMarket : EmployerCenter
    {
        [Get]public string? NameofPlatForm {get; set;}
        [Get]public string? VendorId { get; set; }
        [Get]public string? VendorPassword {get; set;}
        [Detail]public Binary? AccessKey { get; set; }
        [Detail]public Binary? SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity)] public string? PMMCommodities {get; set;}
    }
}
