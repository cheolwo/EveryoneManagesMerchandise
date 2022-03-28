﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext), DbConnectionString.FisheriesDbConnection)]
    [Relation(typeof(FishCommodity), nameof(FishCommodity))]
    public class FishCommodity : Commodity
    {
        public string CopartnershipId { get; set; }
        public Fisheries Fisheries { get; set; }
        public Copartnership Copartnership { get; set; }
        public List<MFishCommodity> MFishCommodities { get; set; }
        public List<EFishCommodity> EFishCommodities { get; set; }
        public List<SFishCommodity> SFishCommodities { get; set; }
    }
}
