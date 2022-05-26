using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofTrade.ofEmployee
{
    [AutoMap(typeof(MTCommodity))]
    public class EmployeeMTCommodity : EmployeeMStatus
    {
        [Query][Get]public bool IsAccecptBillofLading {get; set;}
        [Query][Get]public bool IsAcceptCerticificateofOrigin {get; set;}
        [Query][Get]public bool IsAcceptCredit {get; set;}
        [Query][Get]public string? ETCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommodity {get; set;}
    }
}
