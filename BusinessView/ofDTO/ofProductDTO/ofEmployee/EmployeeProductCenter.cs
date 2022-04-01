using BusinessData;
using BusinessData.ofProduct;
using BusinessView.ofCommon.ofEmployee;

namespace BusinessView.ofProduct.ofEmployee
{
    public static class ViewNameofProductCenter
    {
        public const string ProductCenter = "ProductCenter";
        public const string PCommodity = "PCommodity";
        public const string SPCommodity = "SPCommodity";
        public const string MPCommodity = "MPCommodity";
        public const string EPCommodity =  "EPCommopdity";
        public const string ProductLand = "ProductLand";
    }
    public static class LandCode 
    {
        public const string Product = "Product";
        public const string LiveStock = "LiveStock";
    }
    public class EmployeeProductCenter : EmployeeCenter
    {
        public string Producters {get; set;}
        public string CoprNumber {get; set;}
        [Detail][Many(ViewNameofProductCenter.ProductCenter)] public string ProductLands {get; set;}
        [Detail][Many(ViewNameofProductCenter.PCommodity)] public string PCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.SPCommodity)] public string SPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public string MPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity)] public string EPCommodities {get; set;}
    }

    public class EmployeeProducter : EmployeeCenter
    {
        public ProductCenter ProductCenter { get; set; } 
        public string PCommodity { get; set; }
        public string SPCommodity { get; set; }
        public string MPCommodities { get; set; }    
        public string EPCommodity { get; set;}
    }
    public class EmployeeProductLand : EmployeeEntity
    {
        [Get]public string StartedTime {get; set;}
        [Get]public string AnticipatingEndedTime {get; set;}
        [Get]public string Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public List<string> OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity)] public string PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public string Producter { get; set;}
        public string ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public string MPCommodities {get; set;}
    }
    public class EmployeePCommodity : EmployeeCommodity
    {
        [Detail]public string Category {get; set;}
        [Detail] public string Brand {get; set;}
        [Many] public string SPCommodities {get; set;}
        [Many] public string MPCommodities {get; set;}
        [Many] public string EPCommodities {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        public string Producter {get; set;}  
    }
    public class EmployeeSPCommodity : EmployeeSStatus
    {
        [Get]public string StartedTime {get; set;}
        [Get]public string AnticipatingEndedTime {get; set;}
        [Get]public string Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public List<string> OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity)] public string PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public string Producter { get; set;}
        public string ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public string MPCommodities {get; set;}
    }   
    public class EmployeeMPCommodity : EmployeeMStatus
    {   
        [Detail][One(ViewNameofProductCenter.PCommodity)] public string PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public string Producter { get; set;}
        [Detail][One(ViewNameofProductCenter.SPCommodity)] public string SPCommodity {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity)] public string EPCommodities {get; set;}
    }
    public class EmployeeEPCommodity : EmployeeEStatus
    {   
        [Many][One(ViewNameofProductCenter.PCommodity)] public string PCommodity { get; set; }
        [Many][One(ViewNameofProductCenter.ProductLand)] public string ProductLand {get; set;}
        [Many][One(ViewNameofProductCenter.ProductCenter)] public string Producter { get; set;}
        [Many][One(ViewNameofProductCenter.MPCommodity)] public string MPCommodity {get; set;}
    }
}
