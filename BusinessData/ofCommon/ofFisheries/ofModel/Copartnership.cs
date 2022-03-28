using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext), DbConnectionString.FisheriesDbConnection)]
    [Relation(typeof(Copartnership), nameof(Copartnership))]
    public class Copartnership : Entity
    {
        public List<string> FisheriesId { get; set; }
        
    }
}
