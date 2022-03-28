using System;
using System.Collections.Generic;
using System.Linq;
using BusinessData.ofMarket.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofMarket.ofModel
{
    [DataContext(typeof(MarketDbContext), DbConnectionString.MarketDbConnection)]
    [Authorize(Roles = "Admin_Market")]
    [Relation(typeof(Market), "M")]
    public class Market : Center, IRelatedCenter
    {
        public string NameofMarket { get; set; }
        public List<PlatMarket> PlatMarkets { get; set; }
        public List<MCommodity> MCommodities {get; set;}
        public List<SMCommodity> SMCommodities {get; set; }
        public List<MMCommodity> MMCommodities {get; set;}
        public List<EMCommodity> EMCommodities {get; set;}

        public Market()    
        {
            SetRelation(typeof(Market), "M");
            PlatMarkets = new();
            MCommodities = new();
            SMCommodities = new();
            MMCommodities = new();
            EMCommodities = new();
        }
        public override bool Equals(object obj)
        {
            return obj is Market market &&
                   Id == market.Id &&
                   CreateTime == market.CreateTime &&

                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, market.ImageofInfos) &&
                   Name == market.Name &&
                   UserId == market.UserId &&
                   EqualityComparer<List<PlatMarket>>.Default.Equals(PlatMarkets, market.PlatMarkets);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override Center GetRelatedCenter()
        {
            return this;
        }
    }
}

