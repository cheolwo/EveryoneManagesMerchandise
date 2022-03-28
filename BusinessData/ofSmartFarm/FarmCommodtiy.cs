using System;
using System.Collections.Generic;

namespace BusinessData.ofSmartFarm
{
    [DataContext(typeof(SmartFarmDbContext), DbConnectionString.WarehouseDbConnection)]
    [Relation(typeof(FarmCommodtiy), nameof(FarmCommodtiy))]
    public class FarmCommodtiy : Commodity
    {
        public string PCommodityId {get; set;}
        public SmartFarm SmartFarm {get; set;}
        public ControllerCommodity ControllerCommodity {get; set;}
        public List<SFarmCommodity> SFarmCommodityes {get; set;}
        public List<MFarmCommodity> MFarmCommodityes {get; set;}
        public List<EFarmCommodity> EFarmCommodityes {get; set;}
    }
}