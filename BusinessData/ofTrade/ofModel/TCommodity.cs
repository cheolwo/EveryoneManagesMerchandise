﻿using System.Collections.Generic;
using System;
using BusinessData.ofTrade.ofDbContext;
using System.Reflection;

namespace BusinessData.ofTrade.ofModel
{
    [DataContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    public class TradeCenter : Center
    {
        public List<TCommodity> TCommodities {get; set;}
        public TradeCenter()
        {
            SetRelation(typeof(TradeCenter), "T");
            TCommodities = new();
        }
    }
    [DataContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    public class TCommodity : Commodity
    {
        public string PCommodityId {get; set;}
        public List<STCommodity> STCommodities {get; set;}
        public List<MTCommodity> MTCommodities {get; set;}
        public List<ETCommodity> ETCommodities {get; set;}
        public TradeCenter TradeCenter {get; set;}

        public TCommodity()
        {
            SetRelation(typeof(TCommodity), "TT");
            STCommodities = new();
            MTCommodities = new();
            ETCommodities = new();
            TradeCenter = new();
        }
    }
    [DataContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    public class STCommodity : SStatus
    {
        public string BuyerId {get; set;} 
        public string Message {get; set;}
        public float Payed {get; set;}
        public bool IsAccept {get; set;}
        public string MTCommodityId {get; set;}
        public TCommodity TCommoditiy {get; set;}

        public STCommodity()
        {
            SetRelation(typeof(STCommodity), "TTS");
            TCommoditiy = new();
        }
    }
    [DataContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    public class MTCommodity  : MStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string ETCommodityId {get; set;}
        public TCommodity TCommodity {get; set;}
        public MTCommodity()
        {
            SetRelation(typeof(MTCommodity), "TTM");
            TCommodity = new();
        }
    }
    [DataContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    public class ETCommodity  : EStatus
    {
        public string MTCommodityId {get; set;}
        public string SWCommodityId {get; set;}
        public TCommodity TCommodity { get; set; }
        public ETCommodity()
        {
            SetRelation(typeof(ETCommodity), "TTE");
            TCommodity = new();
        }
    }
    public enum TransactionType { Trade = 0, Contract = 1 }
}
