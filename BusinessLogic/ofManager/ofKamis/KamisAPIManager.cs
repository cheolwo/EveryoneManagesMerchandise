using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using BusinessData.ofCommon.ofKamis.ofModel;
using System.Diagnostics;

namespace BusinessLoogic.ofManager.ofKamis
{
    //public class KamisConvertFactory
    //{
    //    private Dictionary<int, StimulatedFunc> DicStimulatedFunc {get; set;}
    //    private StringBuilder RecognizingBuilder {get; set;}
    //    private Dictionary<string, string> KeyValuePairs {get; set;}
    //    private List<KamisPriceInfo> KamisPriceInfos {get; set;}
    //    public KamisConvertFactory()
    //    {
    //        DicStimulatedFunc = new();
    //        RecognizingBuilder = new();
    //    }
    //    public List<KamisPriceInfo> ToKamisPriceInfos(object[] items)
    //    {
    //        foreach(object item in items)
    //        {
    //            string itemStr = item.ToString();
    //            for(int i = 0; i <= itemStr.Length; i++)
    //            {
    //                bool Check = RecognizeCheck(itemStr[i]);
    //                if(Check) {Recognize(itemStr[i]);}
    //                else
    //                {
    //                    int Stimulation = Math.Abs(RecognizingBuilder.ToString().GetHashCode());
    //                    DicStimulatedFunc[Stimulation](itemStr[i]);
    //                }
    //            }
    //        }
    //    }
    //    // 대괄호가 끝나면 Key And Value로 나타낸 것을 개체화한다.
    //    private bool RecognizeCheck(char c)
    //    {
    //    }    
    //    private void Recognize(char c)
    //    {
    //        RecognizingBuilder.Append(c);
    //        string Rs = RecognizingBuilder.ToString();
    //        int Stimulation = Math.Abs(Rs.GetHashCode());
    //        DicStimulatedFunc[Stimulation](c);
    //    }
    //    // {
    //    private void StimulateFunc0(char c)
    //    {

    //    }
    //    // " ---> propName 즉 Key 구성
    //    private void StimulatedFunc1(char c) 
    //    {

    //    }
    //    // "" ---> Key 구성완료
    //    private void StimulatedFunc2(char c) 
    //    {

    //    }
    //    // "": ---> 아무것도 하지 않음
    //    private void StimulatedFunc3(char c) 
    //    {

    //    }
    //    // "":" ---> propValue 즉 Value 구성
    //    private void StimulatedFunc4(char c) 
    //    {

    //    }
    //    // "":"" ---> Value 구성완료
    //    private void StimulatedFunc5(char c) 
    //    {

    //    }
    //    // "":[ ---> Value를 Empty 로 초기화
    //    private void StimulatedFunc6(char c) 
    //    {

    //    }
    //    // "":[] ---> Value 구성완료
    //    private void StimulatedFunc7(char c) 
    //    {

    //    }
    //    // "":[], ---> 초기화
    //    private void StimulatedFunc8(char c) 
    //    {

    //    }
    //}
    public class KamisAPIManager
    {
        public HttpClient HttpClient { get; }
        private readonly KamisRequestFactory _kamisRequestFactory;
        private readonly KamisMarketManager _kamisMarketManager;
        private readonly KamisWholeSalePriceManager _kamisWholeSalePriceManager;
        private readonly KamisRetailPriceManager _kamisRetailPriceManager;
        private List<KamisPriceInfo> KamisPriceInfos { get; set; }
        private List<AverageKamisPriceInfo> AverageKamisPriceInfos { get; set; }
        private List<BufferAverageKamisPriceInfo> BufferAverageKamisPriceInfos { get; set; }
        private Dictionary<Dictionary<string, string>, List<KamisPriceInfo>> DicWholeSaleKamisPriceInfos { get; set; }
        private Dictionary<Dictionary<string, string>, List<AverageKamisPriceInfo>> DicWholeSaleAverageKamisPriceInfos { get; set; }
        private Dictionary<Dictionary<string, string>, List<KamisPriceInfo>> DicRetailKamisPriceInfos { get; set; }
        private Dictionary<Dictionary<string, string>, List<AverageKamisPriceInfo>> DicRetailAverageKamisPriceInfos { get; set; }
        public ProductPriceResult ProductPriceResult = new();
        public KamisAPIManager(KamisRequestFactory kamisRequestFactory,
            KamisMarketManager kamisMarketManager, KamisWholeSalePriceManager kamisWholeSalePriceManager, KamisRetailPriceManager kamisRetailPriceManager)
        {
            _kamisMarketManager = kamisMarketManager;
            _kamisRetailPriceManager = kamisRetailPriceManager;
            _kamisWholeSalePriceManager = kamisWholeSalePriceManager;
            _kamisRequestFactory = kamisRequestFactory;
            HttpClient = new();
            KamisPriceInfos = new();
            BufferAverageKamisPriceInfos = new();
            AverageKamisPriceInfos = new();
            DicWholeSaleAverageKamisPriceInfos = new();
            DicWholeSaleKamisPriceInfos = new();
            DicRetailKamisPriceInfos = new();
            DicRetailAverageKamisPriceInfos = new();
        }
        public Dictionary<Dictionary<string, string>, List<KamisPriceInfo>> GetDicWholeSaleKamisPriceInfos()
        {
            return DicWholeSaleKamisPriceInfos;
        }
        public Dictionary<Dictionary<string, string>, List<KamisPriceInfo>> GetDicRetailKamisPriceInfos()
        {
            return DicRetailKamisPriceInfos;
        }
        public Dictionary<Dictionary<string, string>, List<AverageKamisPriceInfo>> GetDicWholeSaleAverageKamisPriceInfos()
        {
            return DicWholeSaleAverageKamisPriceInfos;
        }
        public Dictionary<Dictionary<string, string>, List<AverageKamisPriceInfo>> GetDicRetailAverageKamisPriceInfos()
        {
            return DicRetailAverageKamisPriceInfos;
        }
        public List<KamisPriceInfo> GetKamisPriceInfos()
        {
            return KamisPriceInfos;
        }
        public List<AverageKamisPriceInfo> GetAverageKamisPriceInfos()
        {
            return AverageKamisPriceInfos;
        }
        // KamisAPiManager는 HttpRequestFactory 를 이용하여 Json으로 데이터를 받아오는 것 까지를 담당한다.
        // 이제 변환로직과 저장로직을 만들면 되겠다. 
        public async Task CollectPriceInfoFromAPI(string startdate, string enddate)
        {
            await _kamisRequestFactory.CreateRequestMessage(startdate, enddate);
            Dictionary<HttpRequestMessage, Dictionary<string, string>> DicWholeSaleHttpRequestMessage = _kamisRequestFactory.GetDictionaryWholeSalePriceHttpRequestMessage();
            Dictionary<HttpRequestMessage, Dictionary<string, string>> DicRetailHttpRequestMessage = _kamisRequestFactory.GetDictionaryRetailPriceHttpRequestMessage();
            await SaveWholeSalePriceInfoByGetAPI(DicWholeSaleHttpRequestMessage);
            await SaveRetailPriceInfoByGetAPI(DicRetailHttpRequestMessage);
        }
        // 연속적으로 [] 가 나오는 경우 Average Kamis Price Info 에 저장한다.
        // 그게 아닌 경우 KamisPriceInfo 에 저장한다.
        private static List<AverageKamisPriceInfo> CloneAverageKamisPriceInfos(List<AverageKamisPriceInfo> averageKamisPriceInfos)
        {
            List<AverageKamisPriceInfo> newAverageKamisPriceInfos = new();
            foreach (var priceInfo in averageKamisPriceInfos)
            {
                AverageKamisPriceInfo newAverageKamisPriceInfo = new();
                newAverageKamisPriceInfo.regday = priceInfo.regday;
                newAverageKamisPriceInfo.itemname = priceInfo.itemname;
                newAverageKamisPriceInfo.marketname = priceInfo.marketname;
                newAverageKamisPriceInfo.countyname = priceInfo.countyname;
                newAverageKamisPriceInfo.price = priceInfo.price;
                newAverageKamisPriceInfo.kindname = priceInfo.kindname;
                newAverageKamisPriceInfo.yyyy = priceInfo.yyyy;
                newAverageKamisPriceInfos.Add(newAverageKamisPriceInfo);
            }
            return newAverageKamisPriceInfos;
        }
        private static List<KamisPriceInfo> CloneKamisPriceInfos(List<KamisPriceInfo> kamisPriceInfos)
        {
            List<KamisPriceInfo> newKamisPriceInfos = new();
            foreach (var priceInfo in kamisPriceInfos)
            {
                KamisPriceInfo newKamisPriceInfo = new();
                newKamisPriceInfo.regday = priceInfo.regday;
                newKamisPriceInfo.itemname = priceInfo.itemname;
                newKamisPriceInfo.marketname = priceInfo.marketname;
                newKamisPriceInfo.countyname = priceInfo.countyname;
                newKamisPriceInfo.price = priceInfo.price;
                newKamisPriceInfo.kindname = priceInfo.kindname;
                newKamisPriceInfo.yyyy = priceInfo.yyyy;
                newKamisPriceInfos.Add(newKamisPriceInfo);
            }
            return newKamisPriceInfos;
        }
        // 1. 
        private void DivideConvertKamisPriceInfodataitems(object[] items) //ProductPriceResult.data.items
        {
            int Check = 0;
            bool IsContinue = false;
            foreach (var item in items)
            {
                string itemstr = item.ToString();
                bool IsContainItemName = itemstr.Contains("itemname");
                if (IsContainItemName)
                {
                    bool IsConvertToAverage = itemstr.Contains("[]");
                    if (IsConvertToAverage)
                    {
                        BufferAverageKamisPriceInfo averageKamisPriceInfo = JsonConvert.DeserializeObject<BufferAverageKamisPriceInfo>(item.ToString());
                        BufferAverageKamisPriceInfos.Add(averageKamisPriceInfo);
                    }
                    else
                    {
                        KamisPriceInfo kamisPriceInfo = JsonConvert.DeserializeObject<KamisPriceInfo>(itemstr);
                        KamisPriceInfos.Add(kamisPriceInfo);
                    }
                }
                else { continue; }
            }
            ConvertBufToAverageKamisPriceInfo(BufferAverageKamisPriceInfos);
        }
        private void ConvertBufToAverageKamisPriceInfo(List<BufferAverageKamisPriceInfo> bufferAverageKamisPriceInfos)
        {
            foreach (var bufInfo in bufferAverageKamisPriceInfos)
            {
                AverageKamisPriceInfo averageKamisPriceInfo = new();
                averageKamisPriceInfo.itemname = "";
                averageKamisPriceInfo.regday = bufInfo.regday;
                averageKamisPriceInfo.price = bufInfo.price;
                averageKamisPriceInfo.marketname = "";
                averageKamisPriceInfo.countyname = bufInfo.countyname;
                averageKamisPriceInfo.kindname = "";
                averageKamisPriceInfo.yyyy = bufInfo.yyyy;
                AverageKamisPriceInfos.Add(averageKamisPriceInfo);
            }
        }
        public async Task SaveWholeSalePriceInfoByGetAPI(Dictionary<HttpRequestMessage, Dictionary<string, string>> DicWholeSaleHttpRequestMessage)
        {
            var WholeSaleRequestMessages = DicWholeSaleHttpRequestMessage.Keys;
            foreach (var Message in WholeSaleRequestMessages)
            {
                HttpResponseMessage response = await HttpClient.SendAsync(Message);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var Result = await System.Text.Json.JsonSerializer.DeserializeAsync<object>(responseStream);
                    string ResultString = Result.ToString();
                    if (ResultString.Contains("error_code"))
                    {
                        ProductPriceResult = JsonConvert.DeserializeObject<ProductPriceResult>(ResultString);
                        DivideConvertKamisPriceInfodataitems(ProductPriceResult.data.item);
                        foreach (var kamisPriceInfo in GetKamisPriceInfos())
                        {
                            string marketName = kamisPriceInfo.marketname;
                            KamisMarket kamisMarket = await _kamisMarketManager.GetByMarketName(marketName);
                            if (kamisMarket == null)
                            {
                                kamisMarket = await CreateMarket(marketName, DicWholeSaleHttpRequestMessage[Message]);
                            }

                            var newKamisWholeSalePrice = CloneKamisWholeSalePrice(kamisMarket, kamisPriceInfo, DicWholeSaleHttpRequestMessage[Message]);
                           
                            await _kamisWholeSalePriceManager.CreateAsync(newKamisWholeSalePrice);
                        }
                        GetKamisPriceInfos().Clear();
                    }
                }
            }
        }
        public async Task SaveRetailPriceInfoByGetAPI(Dictionary<HttpRequestMessage, Dictionary<string, string>> DicRetailHttpRequestMessage)
        {
            var RetailRequestMessages = DicRetailHttpRequestMessage.Keys;
            foreach (var Message in RetailRequestMessages)
            {
                HttpResponseMessage response = await HttpClient.SendAsync(Message);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var Result = await System.Text.Json.JsonSerializer.DeserializeAsync<object>(responseStream);
                    string ResultString = Result.ToString();
                    if (ResultString.Contains("error_code"))
                    {
                        ProductPriceResult = JsonConvert.DeserializeObject<ProductPriceResult>(ResultString);
                        DivideConvertKamisPriceInfodataitems(ProductPriceResult.data.item);
                        foreach (var kamisPriceInfo in GetKamisPriceInfos())
                        {
                            string marketName = kamisPriceInfo.marketname;
                            KamisMarket kamisMarket = await _kamisMarketManager.GetByMarketName(marketName);
                            if (kamisMarket == null)
                            {
                                kamisMarket = await CreateMarket(marketName, DicRetailHttpRequestMessage[Message]);
                            }

                            var newKamisRetailPrice = CloneKamisRetailPrice(kamisMarket, kamisPriceInfo, DicRetailHttpRequestMessage[Message]);
                            await _kamisRetailPriceManager.CreateAsync(newKamisRetailPrice);
                        }
                        GetKamisPriceInfos().Clear();
                    }
                }
            }
        }
        private KamisRetailPrice CloneKamisRetailPrice(KamisMarket kamisMarket, KamisPriceInfo kamisPriceInfo, Dictionary<string, string> DicPriceInfo)
        {
            KamisRetailPrice newKamisRetailPrice = new();
            newKamisRetailPrice.KamisMarketId = kamisMarket.Id;
            newKamisRetailPrice.Name = kamisPriceInfo.price;
            newKamisRetailPrice.yyyy = kamisPriceInfo.yyyy;
            newKamisRetailPrice.regday = kamisPriceInfo.regday;
            newKamisRetailPrice.KamisKindofCommodityId = DicPriceInfo[nameof(KamisKindofCommodity)];
            newKamisRetailPrice.KamisGradeCode = DicPriceInfo[nameof(KamisGrade)];
            newKamisRetailPrice.KamisClsCode = DicPriceInfo[nameof(KamisCountryAdministrationPart)];
            return newKamisRetailPrice;
        }
        private KamisWholeSalePrice CloneKamisWholeSalePrice(KamisMarket kamisMarket, KamisPriceInfo kamisPriceInfo, Dictionary<string, string> DicPriceInfo)
        {
            KamisWholeSalePrice newKamisWholeSalePrice = new();
            newKamisWholeSalePrice.KamisMarketId = kamisMarket.Id;
            newKamisWholeSalePrice.Name = kamisPriceInfo.price;
            newKamisWholeSalePrice.yyyy = kamisPriceInfo.yyyy;
            newKamisWholeSalePrice.regday = kamisPriceInfo.regday;
            newKamisWholeSalePrice.KamisKindofCommodityId = DicPriceInfo[nameof(KamisKindofCommodity)];
            newKamisWholeSalePrice.KamisGradeCode = DicPriceInfo[nameof(KamisGrade)];
            newKamisWholeSalePrice.KamisClsCode = kamisMarket.KamisCountryAdministrationPartId;
            return newKamisWholeSalePrice;
        }
        private async Task<KamisMarket> CreateMarket(string marketname, Dictionary<string, string> key)
        {
            KamisMarket newKamisMarket = new();
            newKamisMarket.KamisCountryAdministrationPartId = key[nameof(KamisCountryAdministrationPart)];
            newKamisMarket.Name = marketname;
            return await _kamisMarketManager.CreateAsync(newKamisMarket);
        }

        private async Task CollectWholeSalePriceInfoByGetAPI(Dictionary<HttpRequestMessage, Dictionary<string, string>> DicWholeSaleHttpRequestMessage)
        {
            var WholeSaleRequestMessages = DicWholeSaleHttpRequestMessage.Keys;
            foreach (var Message in WholeSaleRequestMessages)
            {
                HttpResponseMessage response = await HttpClient.SendAsync(Message);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var Result = await System.Text.Json.JsonSerializer.DeserializeAsync<object>(responseStream);
                    string ResultString = Result.ToString();
                    if (ResultString.Contains("error_code"))
                    {
                        ProductPriceResult = JsonConvert.DeserializeObject<ProductPriceResult>(ResultString);
                        DivideConvertKamisPriceInfodataitems(ProductPriceResult.data.item);
                        if (GetAverageKamisPriceInfos().Count > 0)
                        {
                            List<AverageKamisPriceInfo> newAverageKamisPriceInfos = new();
                            newAverageKamisPriceInfos = CloneAverageKamisPriceInfos(GetAverageKamisPriceInfos());
                            DicWholeSaleAverageKamisPriceInfos.Add(DicWholeSaleHttpRequestMessage[Message], newAverageKamisPriceInfos);
                            AverageKamisPriceInfos.Clear();
                        }
                        if (GetKamisPriceInfos().Count > 0)
                        {
                            List<KamisPriceInfo> newKamisPriceInfos = new();
                            newKamisPriceInfos = CloneKamisPriceInfos(GetKamisPriceInfos());
                            DicWholeSaleKamisPriceInfos.Add(DicWholeSaleHttpRequestMessage[Message], newKamisPriceInfos);
                            KamisPriceInfos.Clear();
                        }
                    }
                }
            }
        }

        private async Task CollectRetailPriceInfoByGetAPI(Dictionary<HttpRequestMessage, Dictionary<string, string>> DicRetailSaleHttpRequestMessage)
        {
            var RetailSaleRequestMessage = DicRetailSaleHttpRequestMessage.Keys;
            foreach (var Message in RetailSaleRequestMessage)
            {
                HttpResponseMessage response = await HttpClient.SendAsync(Message);
                if (response.IsSuccessStatusCode)
                {
                    using var responseStream = await response.Content.ReadAsStreamAsync();
                    var Result = await System.Text.Json.JsonSerializer.DeserializeAsync<object>(responseStream);
                    string ResultString = Result.ToString();
                    if (ResultString.Contains("error_code"))
                    {
                        ProductPriceResult = JsonConvert.DeserializeObject<ProductPriceResult>(ResultString);
                        DivideConvertKamisPriceInfodataitems(ProductPriceResult.data.item);
                        if (GetAverageKamisPriceInfos().Count > 0)
                        {
                            List<AverageKamisPriceInfo> newAverageKamisPriceInfos = new();
                            newAverageKamisPriceInfos = CloneAverageKamisPriceInfos(GetAverageKamisPriceInfos());
                            DicRetailAverageKamisPriceInfos.Add(DicRetailSaleHttpRequestMessage[Message], newAverageKamisPriceInfos);
                            GetAverageKamisPriceInfos().Clear();
                        }
                        if (GetKamisPriceInfos().Count > 0)
                        {
                            List<KamisPriceInfo> newKamisPriceInfos = new();
                            newKamisPriceInfos = CloneKamisPriceInfos(GetKamisPriceInfos());
                            DicRetailKamisPriceInfos.Add(DicRetailSaleHttpRequestMessage[Message], newKamisPriceInfos);
                            GetAverageKamisPriceInfos().Clear();
                        }
                    }
                }
            }
        }
    }
}