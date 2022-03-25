using System;
using System.Collections.Generic;

namespace BusinessData.ofSmartFarm
{
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(SmartFarm), nameof(SmartFarm))]
    public class SmartFarm : Center
    {
        public string ProductLendId { get; set; }
        public List<FarmController> FarmControllers { get; set; }
        public List<FarmCommodtiy> FarmCommodiites { get; set; }
        public List<SFarmCommodity> SFarmCommodiites { get; set; }
        public List<MFarmCommodity> MFarmCommodiites { get; set; }
        public List<EFarmCommodity> EFarmCommodiites { get; set; }
    }
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(SFarmCommodity), nameof(SFarmCommodity))]
    public class SFarmCommodity : SStatus
    {
        public SmartFarm SmartFarm { get; set; }
        public FarmCommodtiy FarmCommodtiy { get; set; }
        public List<SControllerValue> SControllerValues { get; set; }
    }
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(MFarmCommodity), nameof(MFarmCommodity))]
    public class MFarmCommodity : MStatus
    {
        public SmartFarm SmartFarm { get; set; }
        public FarmCommodtiy FarmCommodtiy { get; set; }
        public List<MControllerValue> MControllerValues { get; set; }
    }
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(EFarmCommodity), nameof(EFarmCommodity))]
    public class EFarmCommodity : EStatus
    {
        public SmartFarm SmartFarm { get; set; }
        public FarmCommodtiy FarmCommodtiy { get; set; }
        public List<EControllerValue> EControllerValues { get; set; }
    }
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(SControllerValue), nameof(SControllerValue))]
    public class SControllerValue : Entity
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float AirPressure { get; set; }
        public float WindSpeed { get; set; }
        public string SFarmCommodityId { get; set; }
        public string ControllerCommodityId { get; set; }
        public SFarmCommodity SFarmCommodiy { get; set; }
        public ControllerCommodity ControllerCommodity { get; set; }
    }
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(MControllerValue), nameof(MControllerValue))]
    public class MControllerValue : Entity
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float AirPressure { get; set; }
        public float WindSpeed { get; set; }
        public string MFarmCommodityId { get; set; }
        public string ControllerCommodityId { get; set; }
        public MFarmCommodity MFarmCommodiy { get; set; }
        public ControllerCommodity ControllerCommodity { get; set; }
    }
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(EControllerValue), nameof(EControllerValue))]
    public class EControllerValue : Entity
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float AirPressure { get; set; }
        public float WindSpeed { get; set; }
        public string EFarmCommodityId { get; set; }
        public string ControllerCommodityId { get; set; }
        public EFarmCommodity EFarmCommodiy { get; set; }
        public ControllerCommodity ControllerCommodity { get; set; }
    }
}