using BusinessData.ofTrade.ofModel;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofTrade.ofEmployee
{
    public class EmployeeTradeCenter : EmployeeCenter
    {
        public List<TCommodity> TCommodities {get; set;}
    }
    public class EmployeeTCommodity : EmployeeCommodity
    {
        public string PCommodityId {get; set;}
        public List<STCommodity> STCommodities {get; set;}
        public List<MTCommodity> MTCommodities {get; set;}
        public List<ETCommodity> ETCommodities {get; set;}
        public TradeCenter TradeCenter {get; set;}
    }
    public class EmployeeSTCommodity : EmployeeSStatus
    {
        public string BuyerId {get; set;} 
        public string Message {get; set;}
        public float Payed {get; set;}
        public bool IsAccept {get; set;}
        public string MTCommodityId {get; set;}
        public TCommodity TCommoditiy {get; set;}
    }
    public class EmployeeMTCommodity : EmployeeMStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string ETCommodityId {get; set;}
        public TCommodity TCommodity {get; set;}
    }
    public class EmployeeETCommodity : EmployeeEStatus
    {
        public string MTCommodityId {get; set;}
        public string SWCommodityId {get; set;}
        public TCommodity TCommodity { get; set; }
    }
}
