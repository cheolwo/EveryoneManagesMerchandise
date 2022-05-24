﻿using AutoMapper;
using BusinessData.ofProduct;
using BusinessView.ofDTO.ofCommon.ofEmployer;

namespace BusinessView.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(Producter))]
    public class EmployerProducter : EmployerCenter
    {
        public string? ProductCenter { get; set; } 
        public string? PCommodity { get; set; }
        public string? SPCommodity { get; set; }
        public string? MPCommodities { get; set; }    
        public string? EPCommodity { get; set;}
    }
}
