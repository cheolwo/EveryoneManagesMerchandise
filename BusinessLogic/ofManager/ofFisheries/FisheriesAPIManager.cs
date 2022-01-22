using BusinessData.ofCommon.ofFisheries.ofModel;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

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
        Task GetFishSCommodity();
        Task GetFishECommodity();
    }
    public class FisheriesAPIManager : IFisheriesAPIManager
    {
        private HttpClient HttpClient { get; set; }
        private readonly IEntityManager<Copartnership> _CopartnershipManager;
        private readonly ICenterManager<Fisheries> _CenterManager;
        private readonly ICommodityManager<FishCommodity> _CommodityManager;
        private readonly ISStatusManager<SFishCommodity> _SFishCommodityManager;
        private readonly IMStatusManager<MFishCommodity> _MFishCommodityManager;
        private readonly IEStatusManager<EFishCommodity> _EFishCommodityManager;
        public FisheriesAPIManager(ICenterManager<Fisheries> centerManager, ICommodityManager<FishCommodity> commodityManager,
            ISStatusManager<SFishCommodity> sFishCommodityManager, IMStatusManager<MFishCommodity> mFishCommodtiyManager,
            IEStatusManager<EFishCommodity> eFishCommodityManager, IEntityManager<Copartnership> CopartnershipManager)
        {
            _CopartnershipManager = CopartnershipManager;
            _CommodityManager = commodityManager;
            _CenterManager = centerManager;
            _SFishCommodityManager = sFishCommodityManager;
            _MFishCommodityManager = mFishCommodtiyManager;
            _EFishCommodityManager = eFishCommodityManager;
            HttpClient = new();
        }
        //public async Task ExcelToDb(Workbook wb)
        //{
        //    Worksheet ws = null;
        //    if (wb != null)
        //    {
        //        ws = wb.Worksheets.get_Item(1) as Worksheet;
        //    }
        //    await ExcelCopartnershipToDb(ws);
        //    await ExcelFisheriesToDb(ws);
        //    await ExcelFishCommodityToDb(ws);
        //}
       public  async Task ExcelCopartnershipToDb(Worksheet ws)
        {
            Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    var copartnership = await _CopartnershipManager.GetByCodeAsync(data[i, 1].ToString());
                    if(copartnership == null)
                    {
                        Copartnership newCopartnership = new();
                        newCopartnership.Code = data[i, 1]?.ToString() ?? "";
                        newCopartnership.Name = data[i, 5]?.ToString() ?? "";
                        await _CopartnershipManager.CreateAsync(newCopartnership);
                        continue;
                    }
                    i++;
                }
            }
            catch
            {
                return;
            }
        }

        public async Task ExcelFisheriesToDb(Worksheet ws)
        {
            Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    var fisheries = await _CenterManager.GetByCodeAsync(data[i, 2].ToString());
                    if (fisheries == null)
                    {
                        Fisheries newCenter = new();
                        newCenter.Code = data[i, 2]?.ToString() ?? "";
                        newCenter.Name = data[i, 6]?.ToString() ?? "";
                        Copartnership copartnership = await _CopartnershipManager.GetByCodeAsync(data[i, 1].ToString());
                        newCenter.CopartnershipId = copartnership.Id;
                        await _CenterManager.CreateAsync(newCenter);
                        continue;
                    }
                    i++;
                }
            }
            catch
            {
                return;
            }
        }

        public async Task ExcelFishCommodityToDb(Worksheet ws)
        {
            Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            FishCommodity fishCommodity = new();
            try
            {
                while (data[i, 1] != null)
                {
                    fishCommodity.Code = data[i, 3]?.ToString() ?? "";
                    fishCommodity.Name = data[i, 7]?.ToString() ?? string.Empty;
                    string FisheriesCode = data[i, 2]?.ToString() ?? string.Empty;
                    string PartnerCode = data[i, 1]?.ToString() ?? string.Empty;
                    var Fisheries = await _CenterManager.GetByCodeAsync(FisheriesCode);
                    var Copartner = await _CopartnershipManager.GetByCodeAsync(PartnerCode);
                    if(Fisheries != null  && Copartner != null)
                    {
                        fishCommodity.FisheriesId = Fisheries.Id;
                        fishCommodity.CopartnershipId = Copartner.Id;
                        await _CommodityManager.CreateAsync(fishCommodity);
                        continue;
                    }
                    i++;
                }
            }
            catch
            {
                return;
            }
        }

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