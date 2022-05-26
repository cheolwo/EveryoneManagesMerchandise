using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData;
using BusinessData.ofTrade.ofModel;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofTrade.ofEmployee
{
    [AutoMap(typeof(STCommodity))]
    public class EmployeeSTCommodity : EmployeeSStatus
    {
        [Query][Get]public string? BuyerId {get; set;} 
        [Query][Get]public string? Message {get; set;}
        [Query][Get]public float Payed {get; set;}
        [Query][Get]public bool IsAccept {get; set;}
        [Query][Get]public string? MTCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommoditiy {get; set;}
    }
}
