using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofTrade.ofEmployee
{
    public class EmployeeMTCommodity : EmployeeMStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string? ETCommodityId {get; set;}
        public string? TCommodity {get; set;}
    }
}
