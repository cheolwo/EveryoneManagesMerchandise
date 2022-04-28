﻿using BusinessData;
using BusinessView.ofCommon.ofEmployer;

namespace BusinessView.ofProduct.ofEmployer
{
    public class EmployerPCommodity : EmployerCommodity
    {
        [Detail]public string Category {get; set;}
        [Detail] public string Brand {get; set;}
        [Many] public string SPCommodities {get; set;}
        [Many] public string MPCommodities {get; set;}
        [Many] public string EPCommodities {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        public string Producter {get; set;}  
    }
}
