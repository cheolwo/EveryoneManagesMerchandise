namespace BusinessData.ofSmartFarm
{
    public class SmartFarm : Center
    {
        public string ProductLendId {get; set;}
        public List<FarmCommodtiy> FarmCommodiites {get; set;}
        public List<SFarmCommodtiy> SFarmCommodiites {get; set;}
        public List<MFarmCommodtiy> MFarmCommodiites {get; set;}
        public List<EFarmCommodtiy> EFarmCommodiites {get; set;}
        public List<FarmStatus> FarmStatuses {get; set;}
    }
    public class FarmCommodtiy : Commodity
    {
        public string PCommodityId {get; set;}
        public string SmartFarmId {get; set;}
        public SmartFarm SmartFarm {get; set;}
        public FarmController FarmController {get; set;}
        public List<SFarmCommodity> SFarmCommodityes {get; set;}
        public List<MFarmCommodity> MFarmCommodityes {get; set;}
        public List<EFarmCommodity> EFarmCommodityes {get; set;}
    }
    public class SFarmCommodiy : SStatus
    {
        public string SmartFarmId {get; set;}
        public string FarmCommodtiyId {get; set;}
        public string FarmControllerId {get; set;}
        public string MPCommodityId {get; set;}
        public SmartFarm SmartFarm {get; set;}
        public FarmCommodtiy FarmCommodtiy {get; set;}
        public FarmController FarmController {get; set;}
        public List<SControllerValue> SControllerValues {get; set;}
    }
    public class MFarmCommodiy : MStatus
    {
        public string SmartFarmId {get; set;}
        public string FarmCommodtiyId {get; set;}
        public string FarmControllerId {get; set;}
        public string MPCommodityId {get; set;}
        public SmartFarm SmartFarm {get; set;}
        public FarmCommodtiy FarmCommodtiy {get; set;}
        public FarmController FarmController{get; set;}
        public List<MContollerValue> MControllerValues {get; set;}
    }
    public class EFarmCommodiy : EStatus
    {
        public string SmartFarmId {get; set;}
        public string FarmCommodtiyId {get; set;}
        public string FarmControllerId {get; set;}
        public string MPCommodityId {get; set;}
        public SmartFarm SmartFarm {get; set;}
        public FarmCommodtiy FarmCommodtiy {get; set;}
        public FarmController FarmController{get; set;}
        public List<EControllerValue> EControllerValues {get; set;}
    }
    public class FarmController : Entity, IRelationalbe
    {
        public List<SControllerValue> SContollerValues {get; set;}
        public List<MControllerValue> MContollerValues {get; set;}
        public List<EControllerValue> EContollerValues {get; set;}
        public string FarmCommodtiyId {get; set;}
        public string SmartFarmId {get; set;}
        public FarmCommodtiy FarmCommodtiy {get; set;}
        public SmartFarm SmartFarm {get; set;}
    }
    public class SConrollerValue : Entity, IRelationable
    {
        public float Temperature {get; set;}
        public float Humidity {get; set;}
        public float AirPressure {get; set;}
        public float WindSpeed {get;set;}
        public string SFarmCommodityId {get; set;}
        public string FarmControllerId {get; set;}
        public SFarmCommodiy SFarmCommodiy {get; set;}
        public FarmController FarmController {get; set;}
    }
    public class MConrollerValue : Entity, IRelationable
    {
        public float Temperature {get; set;}
        public float Humidity {get; set;}
        public float AirPressure {get; set;}
        public float WindSpeed {get;set;}
        public string MFarmCommodityId {get; set;}
        public string FarmControllerId {get; set;}
        public MFarmCommodiy MFarmCommodiy {get; set;}
        public FarmController FarmController {get; set;}
    }
    public class EConrollerValue : Entity, IRelationable
    {
        public float Temperature {get; set;}
        public float Humidity {get; set;}
        public float AirPressure {get; set;}
        public float WindSpeed {get;set;}
        public string EFarmCommodityId {get; set;}
        public string FarmControllerId {get; set;}
        public EFarmCommodiy EFarmCommodiy {get; set;}
        public FarmController FarmController {get; set;}
    }
}