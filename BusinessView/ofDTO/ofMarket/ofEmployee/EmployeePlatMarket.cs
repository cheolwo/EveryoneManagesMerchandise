﻿using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofMarket.ofEmployee
{
    public class EmployeePlatMarket : EmployeeCenter
    {
        [Get]public string? NameofPlatForm {get; set;}
        [Get]public string? VendorId { get; set; }
        [Get]public string? VendorPassword {get; set;}
        [Detail]public byte[]? AccessKey { get; set; }
        [Detail]public byte[]? SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity)] public string? PMMCommodities {get; set;}
    }
}
