using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using BusinessData;
using BusinessData.ofTrade.ofModel;
namespace BusinessView.ofTrade.ofEmployer
{
    [AutoMap(typeof(MTCommodity))]
    public class EmployerMTCommodity : EmployerMStatus
    {
        [Get]public bool IsAccecptBillofLading {get; set;}
        [Get]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Get]public bool IsAcceptCredit {get; set;}
        [Get]public string? ETCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
}
