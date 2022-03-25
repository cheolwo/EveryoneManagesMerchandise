using System;
using System.Collections.Generic;
using System.Reflection;
using BusinessData.ofOrder.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofOrder.ofModel
{
	[Relation(typeof(MOCommodity), nameof(MOCommodity))]
    [DataContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    public class MOCommodity : MStatus
    {
        public OCommodity OCommodity {get; set;}
        public OrderCenter OrderCenter {get; set; }
        public SOCommodity SOCommodity { get; set; }
        public List<EOCommodity> EOCommodities { get; set; }
    }
}
