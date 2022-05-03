using BusinessData;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofDTO.ofProduct.ofEmployee
{
    public class EmployeeEPCommodity : EmployeeEStatus
    {   
        [Many][One(ViewNameofProductCenter.PCommodity)] public string PCommodity { get; set; }
        [Many][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        [Many][One(ViewNameofProductCenter.ProductCenter)] public string Producter { get; set;}
        [Many][One(ViewNameofProductCenter.MPCommodity)] public string MPCommodity {get; set;}
    }
}
