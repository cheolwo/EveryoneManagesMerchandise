using System.Threading.Tasks;
using BusinessData.ofCommon.ofKapt;
using BusinessData.ofGroupOrder.ofModel;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofManager.ofWarehouse.ofIdFactory;

namespace BusinessLogic.ofManager.ofWarehouse
{
    public interface IWarehouseManager : ICenterManager<Warehouse>
    {
        Task<Warehouse> LoginWithDataAsync(string LoginId, string Password);
        Task<bool> WarehouseLoginAsync(string LoginId, string Password);
        Task<Warehouse> CreateByKAptAndGOC(KAptBasicInfo kAptBasicInfo, GOC groupOrderCenter);
    }
    public class WarehouseManager : CenterManager<Warehouse>, IWarehouseManager
    {
        private readonly IWarehouseRepository _WarehouseRepository;
        private readonly IWarehouseIdFactory _WarehouseIdFactory;
        private readonly IWarehouseBlobStorage _WarehouseBlobStorage;
        private readonly IWarehouseFileFactory _WarehouseFileFactory;
        public WarehouseManager(IWarehouseRepository WarehouseRepository,
                               IWarehouseIdFactory WarehouseIdFactory,
                               IWarehouseFileFactory WarehouseFileFactory,
                               IWarehouseBlobStorage WarehouseBlobStorage,
                               CenterPasswordHasher<Warehouse> centerPasswordHasher,
                            DicConvertFactory<Warehouse> dicConvertFactory)
            : base(WarehouseRepository, WarehouseIdFactory, WarehouseFileFactory, WarehouseBlobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _WarehouseRepository = WarehouseRepository;
            _WarehouseIdFactory = WarehouseIdFactory;
            _WarehouseBlobStorage = WarehouseBlobStorage;
            _WarehouseFileFactory = WarehouseFileFactory;
        }
        public async Task<bool> WarehouseLoginAsync(string LoginId, string Password)
        {
            Warehouse warehouse = await base.LoginAsync(LoginId, Password);
            if(warehouse != null)
            {
                return true;
            }
            else { return false; }
        }
        public async Task<Warehouse> CreateByKAptAndGOC(KAptBasicInfo kAptBasicInfo, GOC groupOrderCenter)
        {
            var newWarehouse = InitByKaptAndGOC(kAptBasicInfo, groupOrderCenter);
            newWarehouse.Id = await _WarehouseIdFactory.CreateByKapt(newWarehouse, kAptBasicInfo);
            return await _WarehouseRepository.AddAsync(newWarehouse);    
        }
        private Warehouse InitByKaptAndGOC(KAptBasicInfo kAptBasicInfo, GOC groupOrderCenter)
        {
            Warehouse warehouse = new();
            /*특정한 데이터 대입을 처리한다*/
            warehouse.UserId = groupOrderCenter.Id; // 핵심사항.
            warehouse.Name = kAptBasicInfo.Name;
            warehouse.Address = kAptBasicInfo.StreetAddress;
            warehouse.CountryCode = "KR";
            warehouse.FaxNumber = kAptBasicInfo.ManagementOfficeFax;
            warehouse.PhoneNumber = kAptBasicInfo.ManagementOfficePhoneNumber;
            return warehouse;
        }
        // Id로 Entity를 Load 하는 단계
        // Entity Password와 입력 Password를 비교하는 단계
        // 일치할 시 Entity를 반환하고 아닌 경우 예외처리하는 단계를 포함하는
        // CenterManager 로그인 메서드를 오버라이딩하여
        // Entity가 반환된 경우 관련 데이터를 같이 로드하는 것을 특징으로 하는 WarehouseManager 로그인 메서드
        public async Task<Warehouse> LoginWithDataAsync(string LoginId, string Password)
        {
            Warehouse warehouse = await base.LoginAsync(LoginId, Password);
            warehouse = await _WarehouseRepository.GetRelatedData(warehouse); 
            return warehouse;
        }
    }
    //public class WorkingDeskManager : EntityManager<WorkingDesk>
    //{
    //    public WorkingDeskManager(IWorkingDeskRepository CenterDataRepository,
    //        IWorkingDeskIdFactory workingDeskIdFactory,
    //                           IWorkingDeskFileFactory CenterFileFactory,
    //                           IWorkingDeskBlobStorage blobStorage,
    //                        DicConvertFactory<WorkingDesk> dicConvertFactory)
    //        : base(CenterDataRepository, workingDeskIdFactory, CenterFileFactory, blobStorage, dicConvertFactory)
    //    {

    //    }
    //}
    //public class DotBarcodeManager : EntityManager<DotBarcode>
    //{
    //    public DotBarcodeManager(IDotBarcodeRepository CenterDataRepository,
    //        IDotBarcodeIdFactory dotBarcodeIdFactory,
    //                           IDotBarcodeFileFactory CenterFileFactory,
    //                           IEntityBlobStorage<DotBarcode> blobStorage,
    //                        DicConvertFactory<DotBarcode> dicConvertFactory)
    //        : base(CenterDataRepository, dotBarcodeIdFactory, CenterFileFactory, blobStorage, dicConvertFactory)
    //    {

    //    }
    //}
}