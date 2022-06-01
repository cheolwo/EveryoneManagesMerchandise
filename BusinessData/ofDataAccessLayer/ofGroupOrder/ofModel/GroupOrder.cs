using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel
{
    [Relation(typeof(GOC), nameof(GOC))]
    [DataContext(typeof(GODbContext), DbConnectionString.OrderDbConnection)]
    public class GOC : Center
    {
        public List<string> OrderCenters { get; set; }
        public string WarehouseId { get; set; }
    }
    public class GOCC : Commodity
    {
    }
    public class SGOC : SStatus
    {
        
    }
    
    public class MGOC : MStatus
    {
       
    }
    public class EGOC : EStatus
    {
       
    }
}