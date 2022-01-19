namespace BusinessLogic.ofManagement
{
    public class GOManagement
    {
        private readonly WarehouseManager _WaerhouseManager;
        private readonly GOCManager _GOCManager;
        public GOManagement(WarehouseManager warehouseManager, GOCManager GOCManager)
        {
            _WaerhouseManager = warehouseManager;
            _GOCManager = GOCManager;
        }
        public async Task CreateGOCAndWarehouseByKAptBasicInfo(List<KAptBasicInfo> kAptBasicInfos)
        {
            if(kAptBasicInfos.Count > 0)
            {
                foreach(var kapt in kAptBasicInfos)
                {
                    var GOC = _GOCManager.CreateByKApt(kapt);
                    var Warehouse = _WaerhouseManager.CreateByKAptAndGOC(kapt, GOC);
                    GOC.WarehouseId = Warehouse.Id;
                    _GOCManager.UpdateAsync(GOC);
                }
            }
        }
    }
}