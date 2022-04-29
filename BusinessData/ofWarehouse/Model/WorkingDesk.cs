using System;
using System.Collections.Generic;
using System.Reflection;
using BusinessData.ofCommon.ofInterface;
using BusinessData.ofWarehouse.ofDbContext;

namespace BusinessData.ofWarehouse.Model
{
    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(WorkingDesk), "WD")]
    public class WorkingDesk : Entity
    {
        public WorkingDesk()
        {
            Warehouse = new();
        }

        public bool IsUsed {get; set;}
        public Warehouse Warehouse {get; set;}
    }
    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    public class DotBarcode : Entity
    {
        public DotBarcode()
        {
        }
    }
}