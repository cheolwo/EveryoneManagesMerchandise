using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using BusinessData.ofCommon.ofInterface;
using BusinessData.ofWarehouse.ofDbContext;

namespace BusinessData.ofWarehouse.Model
{
    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    public class LoadFrame : Entity
    {
        public List<MWCommodity> MWCommodities { get; set; }
        public Warehouse Warehouse { get; set; }
        public LoadFrame()
        {
            MWCommodities = new();
            Warehouse = new();
        }
    }
}
