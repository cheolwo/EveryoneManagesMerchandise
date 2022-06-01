using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext), DbConnectionString.FisheriesDbConnection)]
    [Relation(typeof(MFishCommodity), nameof(MFishCommodity))]
    public class MFishCommodity : MStatus
    {
        public Fisheries Fisheries { get; set; }
        public FishCommodity FishCommodity { get; set; }
    }
}
