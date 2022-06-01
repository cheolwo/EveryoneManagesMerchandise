using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext), DbConnectionString.FisheriesDbConnection)]
    [Relation(typeof(EFishCommodity), nameof(EFishCommodity))]
    public class EFishCommodity : EStatus
    {
        public Fisheries Fisheries { get; set; }
        public FishCommodity FishCommodity { get; set; }
    }
}
