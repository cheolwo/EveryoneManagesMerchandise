using BusinessData.ofTrade.ofModel;
using BusinessView.ofCommon.ofPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofTrade.ofPlatform
{
    public class PlatformTrade : PlatformCenter
    {
        public List<TCommodity> TCommodities {get; set;}
    }
    public class PlatformTCommodity : PlatformCommodity
    {
        public string PCommodityId {get; set;}
        public List<STCommodity> STCommodities {get; set;}
        public List<MTCommodity> MTCommodities {get; set;}
        public List<ETCommodity> ETCommodities {get; set;}
        public TradeCenter TradeCenter {get; set;}
    }
    public class PlatformSTCommodity : PlatformSStatus
    {
        public string BuyerId {get; set;} 
        public string Message {get; set;}
        public float Payed {get; set;}
        public bool IsAccept {get; set;}
        public string MTCommodityId {get; set;}
        public TCommodity TCommoditiy {get; set;}
    }
    public class PlatformMTCommodity : PlatformMStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string ETCommodityId {get; set;}
        public TCommodity TCommodity {get; set;}
    }
    public class PlatformETCommodity : PlatformEStatus
    {
        public string MTCommodityId {get; set;}
        public string SWCommodityId {get; set;}
        public TCommodity TCommodity { get; set; }
    }
}
