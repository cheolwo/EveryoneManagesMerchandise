using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using BusinessData.ofProduct.ofDbContext;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;

namespace BusinessData.ofDataAccessLayer.ofProduct
{
    [DataContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    [Relation(typeof(Producter), "Producter")]
    public class Producter : Center
    {
        public ProductCenter ProductCenter { get; set; } 
        public List<PCommodity> PCommodity { get; set; }
        public List<SPCommodity> SPCommodity { get; set; }
        public List<MPCommodity> MPCommodities { get; set; }    
        public List<EPCommodity> EPCommodity { get; set;}
    }
}