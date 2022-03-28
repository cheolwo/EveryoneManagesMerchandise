using System;
using System.Collections.Generic;

namespace BusinessData.ofSmartFarm
{
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(ControllerCommodity), nameof(ControllerCommodity))]
    public class ControllerCommodity : Entity
    {
        public string FarmCommodtiyId {get; set;}
        public string ControllerCommodityId {get; set;}
        public FarmCommodtiy FarmCommodtiy {get; set;}
        public FarmController FarmController {get; set;}
        public List<SControllerValue> SControllerValues {get; set;}
        public List<MControllerValue> MControllerValues {get; set;}
        public List<EControllerValue> EControllerValues {get; set;}
    }
}