using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ModuleTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var request1 = new HttpRequestMessage(HttpMethod.Get,
            "http://www.kamis.or.kr/service/price/xml.do?action=periodProductList" +
            "&p_productclscode=02&p_startday=2020-10-01&p_endday=2020-12-01" +
            "&p_itemcategorycode=200&p_itemcode=212&p_kindcode=00&p_productrankcode=04&p_countrycode=1101&p_convert_kg_yn=Y" +
            "&p_cert_key=c8b4e1e9-273f-4fb4-8d5c-fdfcf7ae1533&p_cert_id=2281&p_returntype=json");
            HttpClient client = new HttpClient();
            var Message1 = await client.SendAsync(request1);
            using var responseStream = await Message1.Content.ReadAsStreamAsync();
            var Reult = await JsonSerializer.DeserializeAsync<object>(responseStream);
            Console.WriteLine(Reult.ToString());

            Console.WriteLine();
            KamisAPIManager kamisAPIManager = new KamisAPIManager();
            var Message2 = await kamisAPIManager.GetPrice();
            Console.WriteLine(Message2.StatusCode);
            
        }
        public class KamisAPIManager
        {
            // ResponseField 
            /*
             *  //itemname :  품목명
             *  //kindname : 품종명
             *  // countryname : 시군구
             *  //marketname :  마켓명
             *  // yyyy : 연도
             *  // regday : 날짜
             *  // price : 가격
             */
            /*
             * http://www.kamis.or.kr/service/price/xml.do?action=periodProductList&p_productclscode=02&p_startday=2015-10-01&p_endday=2015-12-01&p_itemcategorycode=200&p_itemcode=212&p_kindcode=00&p_productrankcode=04&p_countrycode=1101&p_convert_kg_yn=Y&p_cert_key=111&p_cert_id=222&p_returntype=xm
             */
            private HttpClient HttpClient = new();
            private readonly string CertKey = "	c8b4e1e9-273f-4fb4-8d5c-fdfcf7ae1533";
            private readonly string CertId = "2281";
            public KamisAPIManager()
            //c8b4e1e9-273f-4fb4-8d5c-fdfcf7ae1533
            {
                HttpClient.BaseAddress = new("http://www.kamis.or.kr/service/price/xml.do?action=periodProductList");
            }
            public async Task<HttpResponseMessage> GetPrice()
            {
                NameValueCollection query = new();
                query["p_productclscode"] = "02";
                query["p_startday"] = "2021-06-01";
                query["p_endday"] = "2021-07-01";
                query["p_itemcategorycode"] = "200";
                query["p_itemcode"] = "212";
                query["p_kindcode"] = "00";
                query["p_productrankcode"] = "04";
                query["p_countrycode"] = "1101";
                query["p_convert_kg_yn"] = "Y";
                query["p_cert_key"] = CertKey; 
                query["p_cert_id"] = CertId;
                query["p_returntype"] = "xml";
                Console.WriteLine(query.ToString());
                return await HttpClient.GetAsync(query.ToString());
            }

        }
        public static void ReadExcelData()
        {
            Application excelApp = null;
            Workbook wb = null;
            Worksheet ws = null;
            try
            {
                excelApp = new Application();

                // 엑셀 파일 열기
                wb = excelApp.Workbooks.Open(@"C:\Users\user\Desktop\HS별 관세율표");

                // 첫번째 Worksheet
                ws = wb.Worksheets.get_Item(1) as Worksheet;

                // 현재 Worksheet에서 사용된 Range 전체를 선택
                Microsoft.Office.Interop.Excel.Range rng = ws.UsedRange;

                // 현재 Worksheet에서 일부 범위만 선택
                // Excel.Range rng = ws.Range[ws.Cells[2, 1], ws.Cells[5, 3]];

                // Range 데이타를 배열 (One-based array)로
                // 행 17697 : Column : 147
                // 세번 : 1, 4
                // 영문품명 : 1, 5
                // 한글품명 : 1, 6
                // 중량단위 : 1 , 7
                // 수량단위 : 1, 8
                // 나머지는 세율
                // 세번 값 시작 : 2,4
                // 제1류 시작 : 2, 4 끝 1620, 4          
                object[,] data = rng.Value;
                var Part1 = Insert0ToFirstHsCodePart(data);
                foreach (var HsCode in Part1)
                {
                }
                    wb.Close(true);
                excelApp.Quit();
            }
            finally
            {
            }
        }
        static private List<string> Insert0ToFirstHsCodePart(object[,] data)
        {
            List<string> vs = new List<string>();
            for (int i = 2; i <= 1620; i++)
            {
                string HsCode = data[i, 4].ToString();
                HsCode = HsCode.Insert(0, "0");
                vs.Add(HsCode);
            }
            return vs;
        }
    }
}
