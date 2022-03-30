using BusinessData;
using BusinessData.ofMarket.ofModel;
using BusinessView.ofCommon.ofEmployee;
using BusinessView.ofMarekt;

namespace BusinessView.ofMarket.ofEmployee
{
    public class EmployeeMarket : EmployeeCenter
    {
        [Get]public string NameofMarket { get; set; }
        [Many(ViewNameofMarket.PlatMarket)]public List<PlatMarket> PlatMarkets { get; set; }
        [Many(ViewNameofMarket.MCommodity)]public List<MCommodity> MCommodities {get; set;}
        [Many(ViewNameofMarket.SMCommodity)]public List<SMCommodity> SMCommodities {get; set; }
        [Many(ViewNameofMarket.MMCommodity)]public List<MMCommodity> MMCommodities {get; set;}
        [Many(ViewNameofMarket.EMCommodity)]public List<EMCommodity> EMCommodities {get; set;}
    }
    public class EmployeePlatMarket : EmployeeCenter
    {
        [Get]public string NameofPlatForm {get; set;}
        [Get]public string VendorId { get; set; }
        [Get]public string VendorPassword {get; set;}
        [Detail]public byte[] AccessKey { get; set; }
        [Detail]public byte[] SecreatKey { get; set; }
        [Detail][Many(ViewNameofMarket.PMMCommodity)] public List<PMMCommodity> PMMCommodities {get; set;}
    }
    public class EmployeeMCommodity : EmployeeCommodity
    {
        [One(ViewNameofMarket.Market)]public Market Market {get; set;}
        [One(ViewNameofMarket.DetailofMCommodity)]public DetailofMCommodity DetailofMCommodity { get; set; }  // Json 으로 처리한다.
        [One(ViewNameofMarket.Option)]public List<Option> Options { get; set; }
        [One(ViewNameofMarket.SMCommodity)]public List<SMCommodity> SMCommodities {get; set;}
        [One(ViewNameofMarket.MMCommodity)]public List<MMCommodity> MMCommodities {get; set;}
        [One(ViewNameofMarket.EMCommodity)]public List<EMCommodity> EMCommodities {get; set;}
    }
    public class EmployeeSMCommodity : EmployeeSStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public MCommodity MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.MMCommodity)]public List<MMCommodity> MMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public Market Market {get; set;}
        public string SWCommodityId {get; set;}
    }
    public class EmployeeMMCommodity : EmployeeMStatus
    {
        [Detail][One(ViewNameofMarket.PlatMarket)]public PlatMarket PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public Market Market {get; set;}
        [Detail][One(ViewNameofMarket.MCommodity)]public MCommodity MCommodity {get; set;}
        [Detail][Many(ViewNameofMarket.EMCommodity)]public List<EMCommodity> EMCommodities {get; set;}
        [Detail][One(ViewNameofMarket.PMMCommodity)]public PMMCommodity PMMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.SMCommodity)]public SMCommodity SMCommodity {get; set;}
    }
    public class EmployeeEMCommodity : EmployeeEStatus
    {
        [Detail][One(ViewNameofMarket.MCommodity)]public MCommodity MCommodity {get; set;}
        [Detail][One(ViewNameofMarket.MMCommodity)]public MMCommodity MMCommodity {get; set;}
        [Detail][One(ViewNameofMarket.PlatMarket)]public PlatMarket PlatMarket {get; set;}
        [Detail][One(ViewNameofMarket.Market)]public Market Market {get; set;}
    }
}
