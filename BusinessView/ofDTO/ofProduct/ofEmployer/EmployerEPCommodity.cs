using BusinessData;
using BusinessView.ofCommon.ofEmployer;
using BusinessView.ofDTO.ofProduct.ofEmployee;

namespace BusinessView.ofDTO.ofProduct.ofEmployer
{
    public class EmployerEPCommodity : EmployerEStatus
    {   
        [Many][One(ViewNameofProductCenter.PCommodity)] public string PCommodity { get; set; }
        [Many][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        [Many][One(ViewNameofProductCenter.ProductCenter)] public string Producter { get; set;}
        [Many][One(ViewNameofProductCenter.MPCommodity)] public string MPCommodity {get; set;}
    }
}
