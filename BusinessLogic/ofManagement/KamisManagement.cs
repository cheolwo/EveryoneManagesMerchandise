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
    public class ProductPriceResult
    {
        public Condition[] condition { get; set; }
        public Data data { get; set; }
        public class Condition
        {
            public string p_startday { get; set; }
            public string p_endday { get; set; }
            public string p_itemcategorycode { get; set; }
            public string p_itemcode { get; set; }
            public string p_kindcode { get; set; }
            public string p_productrankcode { get; set; }
            public string p_countycode { get; set; }
            public string p_convert_kg_yn { get; set; }
            public string p_key { get; set; }
            public string p_id { get; set; }
            public string p_returntype { get; set; }
        }
        public class Data
        {
            public string error_code { get; set; }
            public object[] item { get; set; }
        }
    }
    public class ProductPrice
    {
        public string itemname { get; set; }
        public string kindname { get; set; }
        public string countryname { get; set; }
        public string marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
    public class PeriodProductPriceListInfo
    {
        public string[] itemname { get; set; }
        public string[] kindname { get; set; }
        public string countyname { get; set; }
        public string[] marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
    public class AverageKamisPriceInfo
    {
        public string itemname { get; set; }
        public string kindname { get; set; }
        public string countyname { get; set; }
        public string marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
    public class BufferAverageKamisPriceInfo
    {
        public string[] itemname { get; set; }
        public string[] kindname { get; set; }
        public string countyname { get; set; }
        public string[] marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
    public class KamisPriceInfo
    {
        public string itemname { get; set; }
        public string kindname { get; set; }
        public string countyname { get; set; }
        public string marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
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
        KamisMarketManager kamisMarketManager, KamisWholeSalePriceManager KamisDayPriceManager, KamisRetailPriceManager kamisRetailPriceManager, KamisAPIManager kamisAPIManager)
        {
            _KamisGradeManager = kamisGradeManager;
            _KamisPartManager = kamisPartManager;
            _KamisCommodityManager = kamisCommodityManager;
            _KamisKindofCommodityManager = kamisKindofCommodityManager;
            _KamisCountryAdministrationPartManager = kamisCountryAdministrationPartManager;
            _KamisMarketManager = kamisMarketManager;
            _KamisRetailPriceManager = kamisRetailPriceManager;
            _KamisAPIManger = kamisAPIManager;
        }
        // 저장로직을 담당한다.
        public async Task SavePriceInfoToDb(string startdate, string enddate)
        {
            await _KamisAPIManger.CollectPriceInfoFromAPI(startdate, enddate);
            var DicWholeSaleAverageKamisPriceInfos = _KamisAPIManger.GetDicWholeSaleAverageKamisPriceInfos();
            var DicWholeSaleKamisPriceInfos = _KamisAPIManger.GetDicWholeSaleKamisPriceInfos();
            var DicRetailKamisPriceInfos = _KamisAPIManger.GetDicRetailKamisPriceInfos();
            var DicRetailAverageKamisPriceInfos = _KamisAPIManger.GetDicRetailAverageKamisPriceInfos();
            int Count = DicWholeSaleAverageKamisPriceInfos.Keys.Count;
            
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
            if (ws4 != null) { await KamisCodeSheet3ToDb(ws4); }
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
