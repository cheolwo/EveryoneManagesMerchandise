﻿using System.Collections.Generic;
using BusinessData.ofProduct.ofDbContext;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon;

namespace BusinessData.ofDataAccessLayer.ofProduct
{
    [Relation(typeof(ProductCenter), "P")]
    [DataContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    public class ProductCenter : Center
    {
        public List<Producter> Producters {get; set;}
        public string CoprNumber {get; set;}
        public List<ProductLand> ProductLands {get; set;}
        public List<PCommodity> PCommodities {get; set;}
        public List<SPCommodity> SPCommodities {get; set;}
        public List<MPCommodity> MPCommodities {get; set;}
        public List<EPCommodity> EPCommodities {get; set;}
        
        public ProductCenter()    
        {
            SetRelation(typeof(ProductCenter), "P");
            ProductLands = new();
            PCommodities = new();
        }      
    }
}