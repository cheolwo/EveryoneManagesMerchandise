﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
        private readonly KamisSubCountryAdministrationPartManager _KamisSubCountryAdministrationPartManager;
        private readonly KamisMarketManager _KamisMarketManager;
        private readonly KamisDayPriceManager _KamisDayPriceManager;
        public KamisManagement(KamisPartManager kamisPartManager, KamisCommodityManager kamisCommodityManager,
        KamisKindofCommodityManager kamisKindofCommodityManager, KamisCountryAdministrationPartManager KamisCountryAdministrationPartManager,
        KamisSubCountryAdministrationPartManager KamisSubCountryAdministrationPartManager, KamisMarketManager KamisMarketManager, KamisDayPriceManager KamisDayPriceManager)
        {
            _KamisPartManager = kamisPartManager;
            _KamisCommodityManager = kamisCommodityManager;
            _KamisKindofCommodityManager = kamisKindofCommodityManager;
            _KamisCountryAdministrationPartManager = KamisCountryAdministrationPartManager;
            _KamisSubCountryAdministrationPartManager = KamisSubCountryAdministrationPartManager;
            _KamisMarketManager = KamisMarketManager;
            _KamisDayPriceManager = KamisDayPriceManager;
        }
        public async Task KamisCodeExcelToDb(Application application)
        {
            Workbook wb = null;
            Worksheet ws1 = null;
            Worksheet ws2 = null;
            Worksheet ws3 = null;
            Worksheet ws5 = null;
            wb = excelApp.Workbooks.Open(HsFilePath);
            if(wb != null)
            {
                ws1 = wb.Worksheets.get_Item(1) as Worksheet;
                ws2 = wb.Worksheets.get_Item(2) as Worksheet;
                ws3 = wb.Worksheets.get_Item(3) as Worksheet;
                ws5 = wb.Worksheets.get_Item(5) as Worksheet;
            }
            if(ws1 != null) { await KamisCodeSheet1ToDb(ws1); } 
            if(ws2 != null) { await KamisCodeSheet2ToDb(ws2); }
            if(ws3 != null) { await KamisCodeSheet3ToDb(ws3); }
            if(ws5 != null) { await KamisCodeSheet5ToDb(ws5); }
        }
        private async Task KamisCodeSheet1ToDb(WorkSheet ws)
        {
            KamisPart kamisPart = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;  
            object[,] data = rng.Value;
            int i = 2;
            while(data[i, 1] != null)
            {
                kamisPart.Id = data[i, 1].ToString();
                kamisPart.Name = data[i, 2].ToString();
                await _KamisPartManager.CreateAsync(kamisPart);
                i++;
            }
            kamisPart = null;
        }
        // 1 : 부류코드, 2 : 품목코드, 3 : 품목명
        private async Task KamisCodeShee21ToDb(WorkSheet ws)
        {
            KamisCommodity kamisCommodity = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;  
            object[,] data = rng.Value;
            int i = 2;
            while(data[i, 1] != null)
            {
                kamisCommodity.KamisPartId = data[i, 1].ToString();
                kamisCommodity.Id = data[i, 2].ToString();
                kamisCommodity.Name = data[i, 3].ToString();
                await _kamisCommodityManager.CreateAsync(kamisCommodity);
                i++;
            }
        }
        private async Task KamisCodeShee31ToDb(WorkSheet ws)
        {
            KamisKindofCommodity kamisKindofCommodity = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;  
            object[,] data = rng.Value;
            int i = 2;
            while(data[i, 1] != null)
            {
                kamisKindofCommodity.KamisCommodityId = data[i, 1]?.ToString()?? "";
                kamisKindofCommodity.Id = data[i, 2]?.ToString() ?? "";
                kamisKindofCommodity.Name = data[i, 4].ToString();
                kamisKindofCommodity.WholesaleShippingUnit = data[i, 5].ToString();
                kamisKindofCommodity.WholeSaleShippingUnizSize = data[i, 6].ToString();
                kamisKindofCommodity.RetailShippingUnit = data[i, 7].ToString();
                kamisKindofCommodity.RetailShippingUnitSize = data[i, 8].ToString();
                kamisKindofCommodity.EcoFriendlyAgriculturalProductShippingUnit = data[i,11].ToString();
                kamisKindofCommodity.EcoFriendlyAgriculturalProductShippingUnitSize = data[i, 12].ToString();
                kamisKindofCommodity.Id = data[i, 13].ToString();
                kamisKindofCommodity.Id = data[i, 14].ToString();
                kamisKindofCommodity.Id = data[i, 16].ToString();
                await _kamisKindofCommodityManager.CreateAsync(kamisKindofCommodity);
                i++;
            }
        }
        private async Task KamisCodeShee51ToDb(WorkSheet ws)
        {
            KamisGrade kamisGrade = new();
            Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;  
            object[,] data = rng.Value;
            int i = 2;
            while(data[i, 1] != null)
            {
                kamisPart.Id = data[i, 1].ToString();
                kamisPart.Name = data[i, 2].ToString();
                await _KamisPartManager.CreateAsync(kamisPart);
                i++;
            }
        }
        



    }
}
