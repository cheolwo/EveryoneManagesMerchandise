using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BusinessData.ofCommon.ofKamis.ofModel;
using BusinessLoogic.ofManager.ofKamis;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;

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
    public class KamisManagement
    {
        private readonly KamisPartManager _KamisPartManager;
        private readonly KamisCommodityManager _KamisCommodityManager;
        private readonly KamisKindofCommodityManager _KamisKindofCommodityManager;
        private readonly KamisCountryAdministrationPartManager _KamisCountryAdministrationPartManager;
        private readonly KamisMarketManager _KamisMarketManager;
        private readonly KamisWholeSalePriceManager _KamisWholeSalePriceManager;
        private readonly KamisRetailPriceManager _KamisRetailPriceManager;
        private readonly KamisGradeManager _KamisGradeManager;
        private readonly KamisAPIManager _KamisAPIManger;
        public KamisManagement(KamisGradeManager kamisGradeManager, KamisPartManager kamisPartManager, KamisCommodityManager kamisCommodityManager,
        KamisKindofCommodityManager kamisKindofCommodityManager, KamisCountryAdministrationPartManager kamisCountryAdministrationPartManager,
        KamisMarketManager kamisMarketManager, KamisWholeSalePriceManager kamisWholePriceManager, KamisRetailPriceManager kamisRetailPriceManager, KamisAPIManager kamisAPIManager)
        {
            _KamisGradeManager = kamisGradeManager;
            _KamisPartManager = kamisPartManager;
            _KamisCommodityManager = kamisCommodityManager;
            _KamisKindofCommodityManager = kamisKindofCommodityManager;
            _KamisCountryAdministrationPartManager = kamisCountryAdministrationPartManager;
            _KamisMarketManager = kamisMarketManager;
            _KamisRetailPriceManager = kamisRetailPriceManager;
            _KamisWholeSalePriceManager = kamisWholePriceManager;
            _KamisAPIManger = kamisAPIManager;
        } 
        // 저장로직을 담당한다.
        public async Task SavePriceInfoToDb(string startdate, string enddate)
        {
            await _KamisAPIManger.CollectPriceInfoFromAPI(startdate, enddate);
            await SaveWholeSalePriceInfoToDb();
            await SaveRetailPriceInfoToDb();
        }
        private async Task SaveWholeSalePriceInfoToDb()
        {
            var DicWholeSaleKamisPriceInfos = _KamisAPIManger.GetDicWholeSaleKamisPriceInfos();
            var Keys = DicWholeSaleKamisPriceInfos.Keys;
            foreach (var key in Keys)
            {
                foreach (var kamisPriceInfo in DicWholeSaleKamisPriceInfos[key])
                {
                    string marketName = kamisPriceInfo.marketname;
                    KamisMarket kamisMarket = await _KamisMarketManager.GetByMarketName(marketName);
                    if (kamisMarket == null)
                    {
                        kamisMarket = await CreateMarket(marketName, key);
                    }
                    KamisWholeSalePrice newKamisWholeSalePrice = new();
                    newKamisWholeSalePrice.KamisMarketId = kamisMarket.Id;
                    newKamisWholeSalePrice.Name = kamisPriceInfo.price;
                    newKamisWholeSalePrice.yyyy = kamisPriceInfo.yyyy;
                    newKamisWholeSalePrice.regday = kamisPriceInfo.regday;
			        newKamisWholeSalePrice.KamisKindofCommodityId = key[nameof(KamisKindofCommodity)];
			        newKamisWholeSalePrice.KamisGradeCode = key[nameof(KamisGrade)];
			        newKamisWholeSalePrice.KamisClsCode = key[nameof(KamisCountryAdministrationPart)];
                    await _KamisWholeSalePriceManager.CreateAsync(newKamisWholeSalePrice);
                }
            }
        }
        private async Task<KamisMarket> CreateMarket(string marketname, Dictionary<string, string> key)
        {
            KamisMarket newKamisMarket = new();
            newKamisMarket.KamisCountryAdministrationPartId = key[nameof(KamisCountryAdministrationPart)];
			newKamisMarket.Name = marketname;
            return await _KamisMarketManager.CreateAsync(newKamisMarket);
        }
        private async Task SaveRetailPriceInfoToDb()
        {
            var DicRetailKamisPriceInfos = _KamisAPIManger.GetDicRetailKamisPriceInfos();
            var Keys = DicRetailKamisPriceInfos.Keys;
            foreach (var key in Keys)
            {
                foreach (var kamisPriceInfo in DicRetailKamisPriceInfos[key])
                {
                    string marketName = kamisPriceInfo.marketname;
                    KamisMarket kamisMarket = await _KamisMarketManager.GetByMarketName(marketName);
                    if (kamisMarket == null)
                    {
                        kamisMarket = await CreateMarket(marketName, key);
                    }
                    KamisRetailPrice newKamisRetailPrice = new();
                    newKamisRetailPrice.KamisMarketId = kamisMarket.Id;
                    newKamisRetailPrice.Name = kamisPriceInfo.price;
                    newKamisWholeSalePrice.yyyy = kamisPriceInfo.yyyy;
                    newKamisWholeSalePrice.regday = kamisPriceInfo.regday;
			        newKamisRetailPrice.KamisKindofCommodityId = key[nameof(KamisKindofCommodity)];
			        newKamisRetailPrice.KamisGradeCode = key[nameof(KamisGrade)];
			        newKamisRetailPrice.KamisClsCode = key[nameof(KamisCountryAdministrationPart)];
                    await _KamisRetailPriceManager.CreateAsync(newKamisRetailPrice);
                }
            }
        }
        public async Task KamisCodeExcelToDb(Workbook wb)
        {
            Worksheet ws1 = null;
            Worksheet ws2 = null;
            Worksheet ws4 = null;
            Worksheet ws5 = null;
            Worksheet ws6 = null;
            if (wb != null)
            {
                ws1 = wb.Worksheets.get_Item(1) as Worksheet;
                ws2 = wb.Worksheets.get_Item(2) as Worksheet;
                ws4 = wb.Worksheets.get_Item(4) as Worksheet;
                ws5 = wb.Worksheets.get_Item(5) as Worksheet;
                ws6 = wb.Worksheets.get_Item(6) as Worksheet;
            }
            if (ws1 != null) { await KamisCodeSheet1ToDb(ws1); }
            if (ws2 != null) { await KamisCodeSheet2ToDb(ws2); }
            if (ws4 != null) { await KamisCodeSheet4ToDb(ws4); }
            if (ws5 != null) { await KamisCodeSheet5ToDb(ws5); }
            if (ws6 != null) { await KamisCodeSheet6ToDb(ws6); }
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
                    kamisPart.CreateTime = DateTime.Today;
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
                    kamisCommodity.CreateTime = DateTime.Today;
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
        public async Task KamisCodeSheet3ToDb(Worksheet ws)
        {
            KamisKindofCommodity kamisKindofCommodity = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    kamisKindofCommodity.CreateTime = DateTime.Today;
                    kamisKindofCommodity.KamisCommodityId = data[i, 1]?.ToString() ?? ""; ;
                    kamisKindofCommodity.Code = data[i, 2]?.ToString() ?? "";
                    kamisKindofCommodity.Id = kamisKindofCommodity.KamisCommodityId + kamisKindofCommodity.Code;
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

        public async Task KamisCodeSheet4ToDb(Worksheet ws)
        {
            KamisKindofCommodity kamisKindofCommodity = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;
            object[,] data = rng.Value;
            int i = 2;
            try
            {
                while (data[i, 1] != null)
                {
                    kamisKindofCommodity.CreateTime = DateTime.Today;
                    kamisKindofCommodity.KamisPartId = data[i, 1]?.ToString() ?? "";
                    kamisKindofCommodity.KamisCommodityId = data[i, 3]?.ToString() ?? ""; ;
                    kamisKindofCommodity.Code = data[i, 5]?.ToString() ?? "";
                    kamisKindofCommodity.Id = kamisKindofCommodity.KamisCommodityId + kamisKindofCommodity.Code;
                    kamisKindofCommodity.Name = data[i, 6]?.ToString() ?? "";
                    kamisKindofCommodity.WholesaleShippingUnit = data[i, 7]?.ToString() ?? "";
                    kamisKindofCommodity.WholeSaleShippingUnizSize = data[i, 8]?.ToString() ?? "";
                    kamisKindofCommodity.RetailShippingUnit = data[i, 9]?.ToString() ?? "";
                    kamisKindofCommodity.RetailShippingUnitSize = data[i, 10]?.ToString() ?? "";
                    kamisKindofCommodity.EcoFriendlyAgriculturalProductShippingUnit = data[i, 13]?.ToString() ?? "";
                    kamisKindofCommodity.EcoFriendlyAgriculturalProductShippingUnitSize = data[i, 14]?.ToString() ?? "";
                    kamisKindofCommodity.WholeSaleGrade = data[i, 15]?.ToString() ?? "";
                    kamisKindofCommodity.RetailSaleGrade = data[i, 16]?.ToString() ?? "";
                    kamisKindofCommodity.EcoFriendlyGrade = data[i, 18]?.ToString() ?? "";
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
                    KamisCountryAdministrationPart.CreateTime = DateTime.Today;
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
