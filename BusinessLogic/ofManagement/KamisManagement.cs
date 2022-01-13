using System.Threading.Tasks;
using BusinessData.ofCommon.ofKamis.ofModel;
using BusinessLoogic.ofManager.ofKamis;
using Microsoft.Office.Interop.Excel;

namespace BusinessLogic.ofManagement
{
    /*
        string longurl = "http://somesite.com/news.php?article=1&lang=en";
        var uriBuilder = new UriBuilder(longurl);
        var query = HttpUtility.ParseQueryString(uriBuilder.Query);
        query["action"] = "login1";
        query["attempts"] = "11";
        uriBuilder.Query = query.ToString();
        longurl = uriBuilder.ToString();
// "http://somesite.com:80/news.php?article=1&lang=en&action=login1&attempts=11"
     */
    //public class GitHubService
    //{
    //    public HttpClient Client { get; }

    //    public GitHubService(HttpClient client)
    //    {
    //        client.BaseAddress = new Uri("https://api.github.com/");
    //        // GitHub API versioning
    //        client.DefaultRequestHeaders.Add("Accept",
    //            "application/vnd.github.v3+json");
    //        // GitHub requires a user-agent
    //        client.DefaultRequestHeaders.Add("User-Agent",
    //            "HttpClientFactory-Sample");

    //        Client = client;
    //    }

    //    public async Task<IEnumerable<GitHubIssue>> GetAspNetDocsIssues()
    //    {
    //        return await Client.GetFromJsonAsync<IEnumerable<GitHubIssue>>(
    //          "/repos/aspnet/AspNetCore.Docs/issues?state=open&sort=created&direction=desc");
    //    }
    //}
    public class KamisPriceInfo
    {
        public string itemname {get; set;}
        public string kindname {get; set;}
        public string countryname {get; set;}
        public string marketname {get; set;}
        public string yyyy {get; set;}
        public string regday {get; set;}
        public string price {get; set;}
    }
    public class KamisAPIManager
    {
        public HttpClient _HttpClient {get;}
        private readonly KamisRequestFactory _kamisRequestFactory;
        private List<KamisPriceInfo> kamisPriceInfos = new();
        public KamisAPIManager()
        {
            _HttpClient = new();
            _kamisRequestFactory = kamisRequestFactory;
        }
        // KamisAPiManager는 HttpRequestFactory 를 이용하여 Json으로 데이터를 받아오는 것 까지를 담당한다.
        public async Task CollectPriceInfoToDbByGetAPI(List<KamisKindofCommodity> kamisKindofCommodity, List<KamisCountryAdministrationPart> kamisCountryAdministrationPart,
                    string startdate, string enddate)
        {
            _kamisRequestFactory.CreateRequestFactory(startdate, enddate, kamisKindofCommodity, kamisCountryAdministrationparts);
            var WholeSaleHttpRequests = _kamisRequestFactory.GetWholeSalePriceHttpRequests();
            var ReatilPrcieHttpRequests = _kamisRequestFactory.GetReatilPrcieHttpRequests();
            CollectWholeSalePriceInfoByGetAPI(WholeSaleHttpRequests);
            CollectRetailPriceInfoByGetAPI(ReatilPrcieHttpRequests);
        }
        public List<KamisPriceInfo> GetKamisPriceInfos()
        {
            return this.kamisPriceInfos;
        }
        private async Task CollectWholeSalePriceInfoByGetAPI(List<HttpRequest> wholeSaleHttpRequests)
        {
            if(wholeSaleHttpRequests != null)
            {
                foreach(var httpRequest in wholeSaleHttpRequests)
                {
                    var Response = await _HttpClient.SendAsync(httpRequest);
                    using var responseStream = await Response.Content.ReadAsStreamAsync();
                    var Result = await JsonSerializer.DeserializeAsync<KamisPriceInfo>(responseStream);
                    kamisPriceInfos.Add(Result);
                }
            }
        }
        private async Task CollectRetailPriceInfoByGetAPI(List<HttpRequest> retailHttpRequests)
        {
            if(wholeSaleHttpRequests != null)
            {
                foreach(var httpRequest in wholeSaleHttpRequests)
                {
                    var Response = await _HttpClient.SendAsync(httpRequest);
                    using var responseStream = await Response.Content.ReadAsStreamAsync();
                    var Result = await JsonSerializer.DeserializeAsync<KamisPriceInfo>(responseStream);
                    kamisPriceInfos.Add(Result);
                }
            }
        }
    }
    public class KamisManagement
    {
        private readonly KamisPartManager _KamisPartManager;
        private readonly KamisCommodityManager _KamisCommodityManager;
        private readonly KamisKindofCommodityManager _KamisKindofCommodityManager;
        private readonly KamisCountryAdministrationPartManager _KamisCountryAdministrationPartManager;
        private readonly KamisSubCountryAdministrationPartManager _KamisSubCountryAdministrationPartManager;
        private readonly KamisMarketManager _KamisMarketManager;
        private readonly KamisDayPriceManager _KamisDayPriceManager;
        private readonly KamisGradeManager _KamisGradeManager;
        private readonly KamisAPIManager _KamisAPIManger;

        public KamisManagement(KamisGradeManager kamisGradeManager, KamisPartManager kamisPartManager, KamisCommodityManager kamisCommodityManager,
        KamisKindofCommodityManager kamisKindofCommodityManager, KamisCountryAdministrationPartManager KamisCountryAdministrationPartManager,
        KamisSubCountryAdministrationPartManager KamisSubCountryAdministrationPartManager, KamisMarketManager KamisMarketManager, KamisDayPriceManager KamisDayPriceManager)
        {
            _KamisGradeManager = kamisGradeManager;
            _KamisPartManager = kamisPartManager;
            _KamisCommodityManager = kamisCommodityManager;
            _KamisKindofCommodityManager = kamisKindofCommodityManager;
            _KamisCountryAdministrationPartManager = KamisCountryAdministrationPartManager;
            _KamisSubCountryAdministrationPartManager = KamisSubCountryAdministrationPartManager;
            _KamisMarketManager = KamisMarketManager;
            _KamisDayPriceManager = KamisDayPriceManager;
        }
        public async Task CollectPriceInfoByHttpAPI(string startdate, string enddate)
        {
            var kamisKindofCommodities = await _KamisKindofCommodityManager.GetToListAsync();
            var kamisCountries = await _KamisCountryAdministrationPartManager.GetToListAsync();
            await _KamisAPIManger.CollectPriceInfoAsync(kamisKindofCommodities, kamisCountries, startdate, enddate);
            var KamisPriceInfos = _KamisAPIManger.GetKamisPriceInfos();
            if(KamisPriceInfos.Count > 0)
            {
                await PriceInfosToDb(kmaisPriceInfos);
            }
        }
        // PriceInfoToDb 를 할 때 외래키로 KindofCommodityId와 
        private async Task PriceInfosToDb(List<KamisPriceInfo> kamisPriceInfos)
        {
            foreach(var priceInfo in kamisPriceInfos)
            {
                string marektname = priceInfo.marketname;
                
            }
        }
        public async Task KamisCodeExcelToDb(Workbook wb)
        {
            Worksheet ws1 = null;
            Worksheet ws2 = null;
            Worksheet ws3 = null;
            Worksheet ws5 = null;
            if (wb != null)
            {
                ws1 = wb.Worksheets.get_Item(1) as Worksheet;
                ws2 = wb.Worksheets.get_Item(2) as Worksheet;
                ws3 = wb.Worksheets.get_Item(3) as Worksheet;
                ws5 = wb.Worksheets.get_Item(5) as Worksheet;
            }
            if (ws1 != null) { await KamisCodeSheet1ToDb(ws1); }
            if (ws2 != null) { await KamisCodeSheet2ToDb(ws2); }
            if (ws3 != null) { await KamisCodeSheet3ToDb(ws3); }
            if (ws5 != null) { await KamisCodeSheet5ToDb(ws5); }
        }
        private async Task KamisCodeSheet1ToDb(Worksheet ws)
        {
            KamisPart kamisPart = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    kamisPart.Id = data[i, 1]?.ToString() ?? "";
                    kamisPart.Name = data[i, 2]?.ToString() ?? "";
                    await _KamisPartManager.CreateAsync(kamisPart);
                    i++;
                }
            }
            catch
            {
                kamisPart = null;
                return;
            }
        }
        // 1 : 부류코드, 2 : 품목코드, 3 : 품목명

        private async Task KamisCodeSheet2ToDb(Worksheet ws)
        {
            KamisCommodity kamisCommodity = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    kamisCommodity.KamisPartId = data[i, 1]?.ToString() ?? "";
                    kamisCommodity.Id = data[i, 2]?.ToString() ?? "";
                    kamisCommodity.Name = data[i, 3]?.ToString() ?? "";
                    await _KamisCommodityManager.CreateAsync(kamisCommodity);
                    i++;
                }
            }
            catch
            {
                kamisCommodity = null;
                return;
            }           
        }
        private async Task KamisCodeSheet3ToDb(Worksheet ws)
        {
            KamisKindofCommodity kamisKindofCommodity = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    kamisKindofCommodity.KamisCommodityId = data[i, 1]?.ToString() ?? "";
                    kamisKindofCommodity.Id = data[i, 2]?.ToString() ?? "";
                    kamisKindofCommodity.Name = data[i, 4]?.ToString() ?? "";
                    kamisKindofCommodity.WholesaleShippingUnit = data[i, 5]?.ToString() ?? "";
                    kamisKindofCommodity.WholeSaleShippingUnizSize = data[i, 6]?.ToString() ?? "";
                    kamisKindofCommodity.RetailShippingUnit = data[i, 7]?.ToString() ?? "";
                    kamisKindofCommodity.RetailShippingUnitSize = data[i, 8]?.ToString() ?? "";
                    kamisKindofCommodity.EcoFriendlyAgriculturalProductShippingUnit = data[i, 11]?.ToString() ?? "";
                    kamisKindofCommodity.EcoFriendlyAgriculturalProductShippingUnitSize = data[i, 12]?.ToString() ?? "";
                    kamisKindofCommodity.WholeSaleGrade = data[i, 13]?.ToString() ?? "";
                    kamisKindofCommodity.RetailSaleGrade = data[i, 14]?.ToString() ?? "";
                    kamisKindofCommodity.EcoFriendlyGrade = data[i, 16]?.ToString() ?? "";
                    await _KamisKindofCommodityManager.CreateAsync(kamisKindofCommodity);
                    i++;
                }
            }
            catch
            {
                kamisKindofCommodity = null;
                return;
            }
        }
        private async Task KamisCodeSheet5ToDb(Worksheet ws)
        {
            KamisGrade kamisGrade = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    kamisGrade.Id = data[i, 1]?.ToString() ?? "";
                    kamisGrade.Name = data[i, 3]?.ToString() ?? "";
                    await _KamisGradeManager.CreateAsync(kamisGrade);
                    i++;
                }
            }
            catch
            {
                kamisGrade = null;
                return;
            }
        }
        // 소매가격선택가능지역
        private async Task KamisCodeSheet6ToDb(Worksheet ws)
        {
            KamisCountryAdministrationPart KamisCountryAdministrationPart = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    KamisCountryAdministrationPart.Id = data[i, 1]?.ToString() ?? "";
                    KamisCountryAdministrationPart.Name = data[i, 2]?.ToString() ?? "";
                    await _KamisCountryAdministrationPartManager.CreateAsync(KamisCountryAdministrationPart);
                    i++;
                }
            }
            catch
            {
                KamisCountryAdministrationPart = null;
                return;
            }
        }
    }
}
