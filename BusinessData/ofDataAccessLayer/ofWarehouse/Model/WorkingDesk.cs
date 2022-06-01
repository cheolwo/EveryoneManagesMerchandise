using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
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