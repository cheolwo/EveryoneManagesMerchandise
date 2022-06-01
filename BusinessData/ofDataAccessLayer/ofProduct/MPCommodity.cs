using BusinessData.ofProduct.ofDbContext;
using System;
using System.Collections.Generic;

namespace BusinessData.ofProduct
{
    [DataContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    [Relation(typeof(MPCommodity), "PLPM")]
    public class MPCommodity : MStatus
    {
        public PCommodity PCommodity { get; set; }
        public ProductLand ProductLand {get; set;}
        public Producter Producter { get; set;}
        public SPCommodity SPCommodity {get; set;}
        public List<EPCommodity> EPCommodities {get; set;}
        public MPCommodity()    
        {
            SetRelation(typeof(MPCommodity), "PLPM");
            PCommodity = new();
        }
        public override bool Equals(object obj)
        {
            return obj is MPCommodity commodity &&
                   base.Equals(obj) &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}