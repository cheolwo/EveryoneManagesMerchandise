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
        // 코드는 그닥 어려지는 않는데 관계를 지어주는 것이다보니 아리송한게 있네.
        public async Task CreateGOCAndWarehouseByKAptBasicInfo(List<KAptBasicInfo> kAptBasicInfos)
        {
            if(kAptBasicInfos.Count > 0)
            {
                foreach(var kapt in kAptBasicInfos)
                {
                    // 이 부분에서 ByKApt 에 따른 Create와 Id 구성이 이룽진다.
                    // Warehouse 또한 마찬가지이다.
                    var GOC = _GOCManager.CreateByKAptBasicInfo(kapt);
                    var Warehouse = _WaerhouseManager.CreateByKAptAndGOC(kapt, GOC);
                    GOC.WarehouseId = Warehouse.Id;
                    _GOCManager.UpdateAsync(GOC);
                }
            }
        }
    }
}