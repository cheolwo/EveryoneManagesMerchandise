using System;
using System.Collections.Generic;
using System.Reflection;
using BusinessData.ofCommon.ofInterface;
using BusinessData.ofGroupOrder.ofDbContext;

namespace BusinessData.ofGroupOrder.ofModel
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