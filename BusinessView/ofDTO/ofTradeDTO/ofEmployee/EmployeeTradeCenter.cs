using BusinessData.ofTrade.ofModel;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofTrade.ofEmployee
{
    public class EmployeeTradeCenter : EmployeeCenter
    {
        public string TCommodities {get; set;}
    }
    public class EmployeeTCommodity : EmployeeCommodity
    {
        public string PCommodityId {get; set;}
        public string STCommodities {get; set;}
        public string MTCommodities {get; set;}
        public string ETCommodities {get; set;}
        public string TradeCenter {get; set;}
    }
    public class EmployeeSTCommodity : EmployeeSStatus
    {
        public string BuyerId {get; set;} 
        public string Message {get; set;}
        public float Payed {get; set;}
        public bool IsAccept {get; set;}
        public string MTCommodityId {get; set;}
        public string TCommoditiy {get; set;}
    }
    public class EmployeeMTCommodity : EmployeeMStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string ETCommodityId {get; set;}
        public string TCommodity {get; set;}
    }
    public class EmployeeETCommodity : EmployeeEStatus
    {
        public string MTCommodityId {get; set;}
        public string SWCommodityId {get; set;}
        public string TCommodity { get; set; }
    }
}
