using AutoMapper;
using BusinessData;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using BusinessData.ofProduct;
using BusinessView.ofDTO.ofCommon;
namespace BusinessView.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(ProductLand))]
    public class EmployeeProductLand : EmployeeEntity
    {
        [Query][Get]public string? StartedTime {get; set;}
        [Query][Get]public string? AnticipatingEndedTime {get; set;}
        [Query][Get]public string? Unit {get; set;}
        [Query][Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Query][Get]public string? OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity)] public string? PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string? ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public string? Producter { get; set;}
        public string? ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public string? MPCommodities {get; set;}
    }
}
