using BusinessData.ofTrade.ofModel;
using BusinessView.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofTrade
{
    public class V_Trade : V_Center
    {
        public List<TCommodity> TCommodities {get; set;}
    }
    public class V_TCommodity : V_Commodity
    {
        public string PCommodityId {get; set;}
        public List<STCommodity> STCommodities {get; set;}
        public List<MTCommodity> MTCommodities {get; set;}
        public List<ETCommodity> ETCommodities {get; set;}
        public TradeCenter TradeCenter {get; set;}
    }
    public class V_STCommodity : V_SStatus
    {
        public string BuyerId {get; set;} 
        public string Message {get; set;}
        public float Payed {get; set;}
        public bool IsAccept {get; set;}
        public string MTCommodityId {get; set;}
        public TCommodity TCommoditiy {get; set;}
    }
    public class V_MTCommodity : V_MStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string ETCommodityId {get; set;}
        public TCommodity TCommodity {get; set;}
    }
    public class V_ETCommodity : V_EStatus
    {
        public string MTCommodityId {get; set;}
        public string SWCommodityId {get; set;}
        public TCommodity TCommodity { get; set; }
    }
}