using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofProduct.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofProduct
{
    [Relation(typeof(ProductCenter), "PLP")]
    [DataContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    public class PCommodity : Commodity
    {
        public string Category {get; set;}
        public string Brand {get; set;}
        public List<SPCommodity> SPCommodities {get; set;}
        public List<MPCommodity> MPCommodities {get; set;}
        public List<EPCommodity> EPCommodities {get; set;}
        public ProductLand ProductLand {get; set;}
        public Producter Producter {get; set;}  

        public PCommodity()          
        {
            SetRelation(typeof(PCommodity), "PP");
            SPCommodities = new();
        }
    }
    public class Message
    {
        public string UserName {get; set;}
        public string Content {get; set;}
    }

    public class ImageInfo
    {
        public int Id {get; set;}
        public string Url {get; set;}
        public string Name {get; set;}
    }
}