using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofTrade.ofEmployee
{
    public class EmployeeMTCommodity : EmployeeMStatus
    {
        [Get]public bool IsAccecptBillofLading {get; set;}
        [Get]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Get]public bool IsAcceptCredit {get; set;}
        [Get]public string? ETCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
}
