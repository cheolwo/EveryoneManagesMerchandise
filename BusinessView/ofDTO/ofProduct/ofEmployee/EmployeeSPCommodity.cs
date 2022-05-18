using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofProduct.ofEmployee
{
    public class EmployeeSPCommodity : EmployeeSStatus
    {
        [Get]public string? StartedTime {get; set;}
        [Get]public string? AnticipatingEndedTime {get; set;}
        [Get]public string? Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public string? OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity)] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public string? Producter { get; set;}
        public string? ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public string? MPCommodities {get; set;}
    }   
}
