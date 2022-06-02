using BusinessData.ofCommon.ofKapt;
using BusinessLogic.ofEntityManager.ofGroupOrder;
using BusinessLogic.ofEntityManager.ofWarehouse;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.ofExternalManager.ofManagerment
{
    public class GOCManagement
    {
        private readonly IWarehouseManager _WaerhouseManager;
        private readonly IGOCManager _GOCManager;
        public GOCManagement(IWarehouseManager warehouseManager, IGOCManager GOCManager)
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
                    var GOC = await _GOCManager.CreateByKAptBasicInfo(kapt);
                    var Warehouse = await _WaerhouseManager.CreateByKAptAndGOC(kapt, GOC);
                    GOC.WarehouseId = Warehouse.Id;
                    await _GOCManager.UpdateAsync(GOC);
                }
            }
        }
    }
}