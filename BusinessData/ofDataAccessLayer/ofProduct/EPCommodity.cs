using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofProduct.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofProduct
{
    [DataContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    [Relation(typeof(EPCommodity), "PLPE")]
    public class EPCommodity : EStatus
    {
        public PCommodity PCommodity { get; set; }
        public ProductLand ProductLand {get; set;}
        public Producter Producter { get; set;}
        public MPCommodity MPCommodity {get; set;}
        public EPCommodity()
            
        {
            SetRelation(typeof(EPCommodity), "PLPE");
            PCommodity = new();
        }
    }
}