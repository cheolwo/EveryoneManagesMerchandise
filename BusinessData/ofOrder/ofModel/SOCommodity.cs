using System;
using System.Collections.Generic;
using System.Reflection;
using BusinessData.ofOrder.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofOrder.ofModel
{
	[Relation(typeof(SOCommodity), nameof(SOCommodity))]
    [DataContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    public class SOCommodity : SStatus
    {
        public string Price { get; set; }
        public string QualityTerms { get; set; }
        public string Incorterms { get; set; }
        public OCommodity OCommodity {get; set;}
        public OrderCenter OrderCenter {get; set;}
        public List<MOCommodity> MOCommodities {get; set;}
    }
}
