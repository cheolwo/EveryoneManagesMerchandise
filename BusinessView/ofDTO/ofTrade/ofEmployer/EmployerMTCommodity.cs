using BusinessView.ofDTO.ofCommon.ofEmployer;

namespace BusinessView.ofTrade.ofEmployer
{
    public class EmployerMTCommodity : EmployerMStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string? ETCommodityId {get; set;}
        public string? TCommodity {get; set;}
    }
}
