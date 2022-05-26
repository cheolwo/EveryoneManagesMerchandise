using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofTrade.ofEmployer
{
    [AutoMap(typeof(MTCommodity))]
    public class EmployerMTCommodity : EmployerMStatus
    {
        [Query][Get]public bool IsAccecptBillofLading {get; set;}
        [Query][Get]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Query][Get]public bool IsAcceptCredit {get; set;}
        [Query][Get]public string? ETCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
}
