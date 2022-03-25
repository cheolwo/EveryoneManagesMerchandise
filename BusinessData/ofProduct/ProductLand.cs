using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using BusinessData.ofProduct.ofDbContext;

namespace BusinessData.ofProduct
{
    [DataContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    [Relation(typeof(ProductCenter), "PL")]
    public class ProductLand : Entity, IRelatedRoles
    {
        public ProductLand()
        {
            Producter = new();
        }
        public string LandCode {get; set;}
        public string Address {get; set;}
        public string AreaofProductLand {get; set;}
        public string AreaofRestProductLand {get; set;}
        public string PlantationType {get; set;}
        public string AreaofPlantation {get; set;}
        public string LandBookCode {get; set;}
        public Producter Producter { get; set;}
        public List<SPCommodity> SPCommodities {get; set;}
        public List<MPCommodity> MPCommodities {get; set;}
        public List<EPCommodity> EPCommodities {get; set;}
        public List<PCommodity> PCommodities {get; set;}
    }
}