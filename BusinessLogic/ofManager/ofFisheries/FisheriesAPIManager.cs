namespace BusinessLogic.ofManager.ofFisheries
{
    // RequestFactory
    // 1. 인증키 신청
    // 2. HttpRequestMessage 형식을 봐야지.
    // 3. Response를 받은 형식을 보고.
    // 4. 변환해서 저장하는 것을 만들면 끝이다.
    // 0. Excel To DB (조합 및 창고이름 및 코드)

    // 수협 산지조합 창고
    // API 로 정보를 받아오면 이를 DB에 저장하는 역할을 담당한다.
    // Open API가 4개이기 때문에 public APIManager 모듈 또한 4개이다.
    public interface IFisheriesAPIManager
    {
        Task GetFisheries();
        Task GetFishMCommodity();
        Task GetFishMCommodity();
        Task GetFishECommodity();       
    }
    public class FisheriesAPIManager : IFisheriesAPIManager
    {
        private HttpClient HttpClient {get; set;}
        private readonly ICenterManaegr<Fisheries> _CenterManager;
        private readonly ICommodityManager<FishCommodity> _CommodityManager;
        private readonly ISStatusManager<SFishCommodity> _SFishCommodityManager;
        private readonly IMStatusManager<MFishCommodity> _MFishCommodityManager;
        private readonly IEStatusManager<EFishCommodity> _EFishCommodityManager;
        // 창고정보 API Key
        private const string CetnerAPIKey = "";
        // 재고정보 API Key
        private const string MCommodityAPIKey = "";
        // 입출고정보 API Key
        private const string SECommodityAPIKey = ""; 
        public FisheriesAPIManager(ICenterManager<Fisheries> centerManager, ICommodityManager<FishCommodity> commodityManager,
            ISStatusManager<SFishCommodity> sFishCommodityManager, IMStatusManager<MFishCommdity> mFishCommodtiyManager,
            IEStatusManager<EFishCommodity> eFishCommodityManager)
        {
                _CommodityManager =  commodityManager;
                _CenterManager = centerManager;
                _SFishCommodityManager = sFishCommodityManager;
                _MFishCommodityManager = mFishCommodtiyManager;
                _EFishCommodityManager = eFishCommodityManager;
                HttpClient = new();
        }
        // 1. GetToList - 조합 및 창고정보
        // 2. 상기 정보를 이용해 RequestFactory 작성
        // 3. HttpClient를 이용해 SendAsync 후 ResponseMessage 검사
        // 4. ResponseMessage 에 대한 .Net 개체 변환
        // 5. 상기 개체 중복성 검사 후 Fisheries DB 에 저장하는 것을
        // 특징으로 하는 Fisheries API Manager Get 모듈.
        public async Task GetFisheries()
        {
            
        }
        public async Task GetFishSCommodity()
        {

        }
        public async Task GetFishMCommodity()
        {

        }
        public async Task GetFishECommodity()
        {

        }
        public async Task GetFisheriesToDb()
        {

        }
        public async Task GetFishSCommodityToDb()
        {

        }
        public async Task GetFishMCommodityToDb()
        {

        }
        public async Task GetFishECommodityToDb()
        {

        }
    }
}