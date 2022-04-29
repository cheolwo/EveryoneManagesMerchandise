using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using BusinessData.ofCommon.ofInterface;
using BusinessData.ofWarehouse.ofDbContext;

namespace BusinessData.ofWarehouse.Model
{
    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(IncomingTag), "IT")]
    public class IncomingTag : Entity
    {
         public string SWCommodityId { get; set; }
         public string WareohuseId {get; set;}
        public Warehouse Warehouse { get; set; }
        public List<DividedTag> DividedTags { get; set; }

        public string GetBarcodeInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}
