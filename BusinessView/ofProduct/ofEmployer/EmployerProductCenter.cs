using BusinessData;
using BusinessData.ofProduct;
using BusinessView.ofCommon.ofEmployer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofProduct.ofEmployer
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
    public class EmployerProductCenter : EmployerCenter
    {
        public List<Producter> Producters {get; set;}
        public string CoprNumber {get; set;}
        [Detail][Many(ViewNameofProductCenter.ProductCenter)] public List<ProductLand> ProductLands {get; set;}
        [Detail][Many(ViewNameofProductCenter.PCommodity)] public List<PCommodity> PCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.SPCommodity)] public List<SPCommodity> SPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public List<MPCommodity> MPCommodities {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity)] public List<EPCommodity> EPCommodities {get; set;}
    }

    public class EmployerProducter : EmployerCenter
    {
        public ProductCenter ProductCenter { get; set; } 
        public List<PCommodity> PCommodity { get; set; }
        public List<SPCommodity> SPCommodity { get; set; }
        public List<MPCommodity> MPCommodities { get; set; }    
        public List<EPCommodity> EPCommodity { get; set;}
    }
    public class EmployerProductLand : EmployerEntity
    {
        [Get]public string StartedTime {get; set;}
        [Get]public string AnticipatingEndedTime {get; set;}
        [Get]public string Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public List<string> OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity)] public PCommodity PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public ProductLand ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public Producter Producter { get; set;}
        public ProductCenter ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public List<MPCommodity> MPCommodities {get; set;}
    }
    public class EmployerPCommodity : EmployerCommodity
    {
        [Detail]public string Category {get; set;}
        [Detail] public string Brand {get; set;}
        [Many] public List<SPCommodity> SPCommodities {get; set;}
        [Many] public List<MPCommodity> MPCommodities {get; set;}
        [Many] public List<EPCommodity> EPCommodities {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductLand)] public ProductLand ProductLand {get; set;}
        public Producter Producter {get; set;}  
    }
    public class EmployerSPCommodity : EmployerSStatus
    {
        [Get]public string StartedTime {get; set;}
        [Get]public string AnticipatingEndedTime {get; set;}
        [Get]public string Unit {get; set;}
        [Get]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [Get]public List<string> OrderGroups {get; set;}
        [Detail][One(ViewNameofProductCenter.PCommodity)] public PCommodity PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public ProductLand ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public Producter Producter { get; set;}
        public ProductCenter ProductCenter {get; set;}
        [Detail][Many(ViewNameofProductCenter.MPCommodity)] public List<MPCommodity> MPCommodities {get; set;}
    }   
    public class EmployerMPCommodity : EmployerMStatus
    {   
        [Detail][One(ViewNameofProductCenter.PCommodity)] public PCommodity PCommodity { get; set; }
        [Detail][One(ViewNameofProductCenter.ProductLand)] public ProductLand ProductLand {get; set;}
        [Detail][One(ViewNameofProductCenter.ProductCenter)] public Producter Producter { get; set;}
        [Detail][One(ViewNameofProductCenter.SPCommodity)] public SPCommodity SPCommodity {get; set;}
        [Detail][Many(ViewNameofProductCenter.EPCommodity)] public List<EPCommodity> EPCommodities {get; set;}
    }
    public class EmployerEPCommodity : EmployerEStatus
    {   
        [Many][One(ViewNameofProductCenter.PCommodity)] public PCommodity PCommodity { get; set; }
        [Many][One(ViewNameofProductCenter.ProductLand)] public ProductLand ProductLand {get; set;}
        [Many][One(ViewNameofProductCenter.ProductCenter)] public Producter Producter { get; set;}
        [Many][One(ViewNameofProductCenter.MPCommodity)] public MPCommodity MPCommodity {get; set;}
    }
}
