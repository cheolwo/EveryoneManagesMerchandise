using System;

namespace BusinessData.ofSmartFarm
{
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(FarmController), nameof(FarmController))]
    public class FarmController : Entity
    {
        public string ControllerCommodtiyId {get; set;}
        public string SmartFarmId {get; set;}
        public ControllerCommodity ControllerCommodity {get; set;}
        public SmartFarm SmartFarm {get; set;}
    }
}