using System.Threading.Tasks;
using BusinessData.ofCommon.ofKapt;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofIdFactory;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofGroupOrder
{
    public interface IGOCManager : ICenterManager<GOC>
    {
        Task<GOC> LoginWithDataAsync(string LoginId, string Password);
        Task<bool> GOCLoginAsync(string LoginId, string Password);
        Task<GOC> CreateByKAptBasicInfo(KAptBasicInfo kAptBasicInfo);
    }
    public class GOCManager : CenterManager<GOC>, IEmployerGOCManager, IEmployeeGOCManager, IPlatformGOCManager, IGOCManager
    {
        private readonly IGOCRepository _GOCRepository;
        private readonly IGOCIdFactory _GroupCenterIdFactory;
        public GOCManager(IGOCRepository GOCRepository,
                               IGOCIdFactory GOCIdFactory,
                               IGOCFileFactory GOCFileFactory,
                               IGOCBlobStorage blobStorage,
                               CenterPasswordHasher<GOC> centerPasswordHasher,
                            DicConvertFactory<GOC> dicConvertFactory)
            : base(GOCRepository, GOCIdFactory, GOCFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _GOCRepository = GOCRepository;
            _GroupCenterIdFactory = GOCIdFactory;
        }
        public async Task<GOC> CreateByKAptBasicInfo(KAptBasicInfo kAptBasicInfo)
        {
            var newGOC = InitByKApt(kAptBasicInfo);
            newGOC.Id = await _GroupCenterIdFactory.CreateByKApt(newGOC, kAptBasicInfo); 
            return await _GOCRepository.AddAsync(newGOC); 
        }
        private GOC InitByKApt(KAptBasicInfo kAptBasicInfo)
        {
            GOC GOC = new();
            GOC.Address = kAptBasicInfo.StreetAddress;
            GOC.CountryCode = "KR";
            GOC.FaxNumber = kAptBasicInfo.ManagementOfficeFax;
            GOC.Name = kAptBasicInfo.Name;
            GOC.PhoneNumber = kAptBasicInfo.ManagementOfficePhoneNumber;
            return GOC;
        }
        public async Task<bool> GOCLoginAsync(string LoginId, string Password)
        {
            GOC GOC = await base.LoginAsync(LoginId, Password);
            if(GOC != null)
            {
                return true;
            }
            else { return false; }
        }

        // Id??? Entity??? Load ?????? ??????
        // Entity Password??? ?????? Password??? ???????????? ??????
        // ????????? ??? Entity??? ???????????? ?????? ?????? ?????????????????? ????????? ????????????
        // CenterManager ????????? ???????????? ?????????????????????
        // Entity??? ????????? ?????? ?????? ???????????? ?????? ???????????? ?????? ???????????? ?????? GOCManager ????????? ?????????
        public async Task<GOC> LoginWithDataAsync(string LoginId, string Password)
        {
            GOC GOC = await base.LoginAsync(LoginId, Password);
            GOC = await _GOCRepository.GetRelatedData(GOC); 
            return GOC;
        }
    }
}