using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofTrade.ofEmployee
{
    public class EmployeeSTCommodity : EmployeeSStatus
    {
        [Get]public string? BuyerId {get; set;} 
        [Get]public string? Message {get; set;}
        [Get]public float Payed {get; set;}
        [Get]public bool IsAccept {get; set;}
        [Get]public string? MTCommodityId {get; set;}
        [Detail][One(typeof(TCommodity))]public string? TCommoditiy {get; set;}
    }
}
